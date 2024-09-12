﻿// Copyright (c) 2022-Now 少林寺驻北固山办事处大神父王喇嘛
// 
// OPDispensary 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
// 1.请不要删除和修改根目录下的LICENSE文件。
// 2.请不要删除和修改OPDispensary源码头部的版权声明。
// 3.分发源码时候，请注明软件出处 https://gitee.com/dotnetmoyu/OPDispensary
// 4.基于本软件的作品，只能使用 OPDispensary 作为后台服务，除外情况不可商用且不允许二次分发或开源。
// 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为。
// 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关。

namespace OPDispensary.System;

/// <summary>
///     单页服务
/// </summary>
public interface ISpaService : ITransient
{
    /// <summary>
    ///     添加单页
    /// </summary>
    /// <param name="input">添加参数</param>
    /// <returns></returns>
    Task Add(SpaAddInput input);

    /// <summary>
    ///     删除单页
    /// </summary>
    /// <param name="input">删除参数</param>
    /// <returns></returns>
    Task Delete(BaseIdListInput input);

    /// <summary>
    ///     编辑单页
    /// </summary>
    /// <param name="input">编辑参数</param>
    /// <returns></returns>
    Task Edit(SpaEditInput input);

    /// <summary>
    ///     分页查询
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<SqlSugarPagedList<SysResource>> Page(SpaPageInput input);

    /// <summary>
    ///     详情
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<SysResource> Detail(BaseIdInput input);
}