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
///     模块分页输入
/// </summary>
public class ModulePageInput : BasePageInput
{
}

/// <summary>
///     添加模块输入
/// </summary>
public class ModuleAddInput : SysResource
{
}

/// <summary>
///     编辑模块输入
/// </summary>
public class ModuleEditInput : ModuleAddInput
{
    /// <summary>
    ///     ID
    /// </summary>
    [IdNotNull(ErrorMessage = "Id不能为空")]
    public override long Id { get; set; }
}