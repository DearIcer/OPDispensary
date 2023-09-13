﻿// SimpleAdmin 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
// 1.请不要删除和修改根目录下的LICENSE文件。
// 2.请不要删除和修改SimpleAdmin源码头部的版权声明。
// 3.分发源码时候，请注明软件出处 https://gitee.com/zxzyjs/SimpleAdmin
// 4.基于本软件的作品。，只能使用 SimpleAdmin 作为后台服务，除外情况不可商用且不允许二次分发或开源。
// 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为不要删除和修改作者声明。
// 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关。

namespace SimpleAdmin.System;

/// <summary>
/// 会话管理服务
/// </summary>
public interface ISessionService : ITransient
{
    /// <summary>
    /// 会话统计
    /// </summary>
    /// <returns>统计结果</returns>
    SessionAnalysisOutPut Analysis();

    /// <summary>
    /// 强退会话
    /// </summary>
    /// <param name="input">用户ID</param>
    Task ExitSession(BaseIdInput input);

    /// <summary>
    /// 强退token
    /// </summary>
    /// <param name="input">token列表</param>
    Task ExitToken(ExitTokenInput input);

    /// <summary>
    /// B端会话分页查询
    /// </summary>
    /// <param name="input">查询参数</param>
    /// <returns>B端会话列表</returns>
    Task<SqlSugarPagedList<SessionOutput>> PageB(SessionPageInput input);

    /// <summary>
    /// C端会话分页查询
    /// </summary>
    /// <param name="input">查询参数</param>
    /// <returns>C端会话列表</returns>
    Task<SqlSugarPagedList<SessionOutput>> PageC(SessionPageInput input);
}
