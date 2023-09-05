﻿// SimpleAdmin 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
// 1.请不要删除和修改根目录下的LICENSE文件。
// 2.请不要删除和修改SimpleAdmin源码头部的版权声明。
// 3.分发源码时候，请注明软件出处 https://gitee.com/zxzyjs/SimpleAdmin
// 4.基于本软件的作品。，只能使用 SimpleAdmin 作为后台服务，除外情况不可商用且不允许二次分发或开源。
// 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为不要删除和修改作者声明。
// 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关。

namespace SimpleAdmin.System;

/// <summary>
/// 文件导入通用输出
/// </summary>
public class ImportPreviewOutput<T> where T : class
{
    /// <summary>
    /// 是否有错误
    /// </summary>
    public bool HasError { get; set; }

    /// <summary>
    /// 动态表头
    /// </summary>
    public List<TableColumns> TableColumns { get; set; } = new List<TableColumns>();

    /// <summary>
    /// 数据
    /// </summary>
    public List<T> Data { get; set; }
}

/// <summary>
/// 动态表头
/// </summary>
public class TableColumns
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 数据源
    /// </summary>
    public string DataIndex { get; set; }

    /// <summary>
    /// 宽度
    /// </summary>
    public int Width { get; set; } = 120;

    /// <summary>
    /// 超过宽度将自动省略
    /// </summary>
    public bool Ellipsis { get; set; } = false;

    /// <summary>
    /// 是否是日期格式
    /// </summary>
    public bool Date { get; set; } = false;
}