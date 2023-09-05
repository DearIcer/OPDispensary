﻿// SimpleAdmin 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
// 1.请不要删除和修改根目录下的LICENSE文件。
// 2.请不要删除和修改SimpleAdmin源码头部的版权声明。
// 3.分发源码时候，请注明软件出处 https://gitee.com/zxzyjs/SimpleAdmin
// 4.基于本软件的作品。，只能使用 SimpleAdmin 作为后台服务，除外情况不可商用且不允许二次分发或开源。
// 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为不要删除和修改作者声明。
// 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关。

namespace SimpleAdmin.System;

/// <inheritdoc cref="IConfigService"/>
public class ConfigService : DbRepository<SysConfig>, IConfigService
{
    private readonly ISimpleCacheService _simpleCacheService;

    public ConfigService(ISimpleCacheService simpleCacheService)
    {
        _simpleCacheService = simpleCacheService;
    }

    /// <inheritdoc/>
    public async Task<List<SysConfig>> GetListByCategory(string category)
    {
        var key = SystemConst.CACHE_DEV_CONFIG + category;//系统配置key
        //先从redis拿配置
        var configList = _simpleCacheService.Get<List<SysConfig>>(key);
        if (configList == null)
        {
            //redis没有再去数据可拿
            configList = await GetListAsync(it => it.Category == category);//获取系统配置列表
            if (configList.Count > 0)
            {
                _simpleCacheService.Set(key, configList);//如果不为空,插入redis
            }
        }
        return configList;
    }

    /// <inheritdoc/>
    public async Task<SysConfig> GetByConfigKey(string category, string configKey)
    {
        var configList = await GetListByCategory(category);//获取系统配置列表
        var configValue =
            configList.Where(it => it.ConfigKey == configKey).FirstOrDefault();//根据configkey获取对应值
        return configValue;
    }

    /// <inheritdoc/>
    public async Task<SqlSugarPagedList<SysConfig>> Page(ConfigPageInput input)
    {
        var query = Context.Queryable<SysConfig>()
            .Where(it => it.Category == CateGoryConst.CONFIG_BIZ_DEFINE)//自定义配置
            .WhereIF(!string.IsNullOrEmpty(input.SearchKey),
                it => it.ConfigKey.Contains(input.SearchKey)
                    || it.ConfigKey.Contains(input.SearchKey))//根据关键字查询
            .OrderByIF(!string.IsNullOrEmpty(input.SortField),
                $"{input.SortField} {input.SortOrder}")//排序
            .OrderBy(it => it.SortCode);
        var pageInfo = await query.ToPagedListAsync(input.PageNum, input.PageSize);//分页
        return pageInfo;
    }

    /// <inheritdoc/>
    public async Task Add(ConfigAddInput input)
    {
        await CheckInput(input);
        var devConfig = input.Adapt<SysConfig>();//实体转换
        if (await InsertAsync(devConfig))//插入数据)
            await RefreshCache(CateGoryConst.CONFIG_BIZ_DEFINE);//刷新缓存
    }

    /// <inheritdoc/>
    public async Task Edit(ConfigEditInput input)
    {
        await CheckInput(input);
        var devConfig = input.Adapt<SysConfig>();//实体转换
        if (await UpdateAsync(devConfig))//更新数据
            await RefreshCache(CateGoryConst.CONFIG_BIZ_DEFINE);//刷新缓存
    }

    /// <inheritdoc/>
    public async Task Delete(ConfigDeleteInput input)
    {
        //获取所有业务配置
        var configs = await GetListByCategory(CateGoryConst.CONFIG_BIZ_DEFINE);
        if (configs.Any(it => it.Id == input.Id))//如果有当前配置
        {
            if (await DeleteByIdAsync(input.Id))//删除配置
                await RefreshCache(CateGoryConst.CONFIG_BIZ_DEFINE);//刷新缓存
        }
    }

    /// <inheritdoc/>
    public async Task EditBatch(List<SysConfig> devConfigs)
    {
        if (devConfigs.Count > 0)
        {
            //根据分类分组
            var configGroups = devConfigs.GroupBy(it => it.Category).ToList();
            //遍历分组
            foreach (var item in configGroups)
            {
                var configList = await GetListByCategory(item.Key);//获取系统配置列表
                var configs = item.ToList();//获取分组完的配置列表
                var keys = configs.Select(it => it.ConfigKey).ToList();//获取key列表
                configList = configList.Where(it => keys.Contains(it.ConfigKey)).ToList();//获取要修改的列表
                //遍历配置列表
                configList.ForEach(it =>
                {
                    //赋值ConfigValue
                    it.ConfigValue = configs.Where(c => c.ConfigKey == it.ConfigKey).First()
                        .ConfigValue;
                });
                //更新数据
                if (await UpdateRangeAsync(configList))
                    await RefreshCache(item.Key);//刷新缓存
            }
        }
    }

    #region 方法

    /// <summary>
    /// 刷新缓存
    /// </summary>
    /// <param name="category">分类</param>
    /// <returns></returns>
    private async Task RefreshCache(string category)
    {
        _simpleCacheService.Remove(SystemConst.CACHE_DEV_CONFIG + category);//redis删除
        await GetListByCategory(category);//重新获取
    }

    /// <summary>
    /// 检查输入参数
    /// </summary>
    /// <param name="sysConfig"></param>
    private async Task CheckInput(SysConfig sysConfig)
    {
        var configs = await GetListByCategory(CateGoryConst.CONFIG_BIZ_DEFINE);//获取全部字典
        //判断是否从存在重复字典名
        var hasSameKey =
            configs.Any(it => it.ConfigKey == sysConfig.ConfigKey && it.Id != sysConfig.Id);
        if (hasSameKey)
        {
            throw Oops.Bah($"存在重复的配置键:{sysConfig.ConfigKey}");
        }
        //设置分类为业务
        sysConfig.Category = CateGoryConst.CONFIG_BIZ_DEFINE;
    }

    #endregion 方法
}
