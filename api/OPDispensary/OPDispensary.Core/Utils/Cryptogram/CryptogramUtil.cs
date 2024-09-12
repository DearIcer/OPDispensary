﻿// Copyright (c) 2022-Now 少林寺驻北固山办事处大神父王喇嘛
// 
// OPDispensary 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
// 1.请不要删除和修改根目录下的LICENSE文件。
// 2.请不要删除和修改OPDispensary源码头部的版权声明。
// 3.分发源码时候，请注明软件出处 https://gitee.com/dotnetmoyu/OPDispensary
// 4.基于本软件的作品，只能使用 OPDispensary 作为后台服务，除外情况不可商用且不允许二次分发或开源。
// 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为。
// 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关。

namespace OPDispensary.Core.Utils;

/// <summary>
///     加解密功能
/// </summary>
public class CryptogramUtil
{
    #region SM2

    /// <summary>
    ///     SM2解密
    /// </summary>
    /// <param name="str">密文</param>
    /// <returns>明文</returns>
    public static string Sm2Decrypt(string str)
    {
        // 解密
        if (!string.IsNullOrWhiteSpace(str))
            return SM2Util.Decrypt(str);
        try
        {
            // // 解密
            // if (!string.IsNullOrWhiteSpace(str))
            //     return SM2Util.Decrypt(str);
        }
        catch
        {
            return "";
        }

        return "";
    }

    /// <summary>
    ///     SM2加密
    /// </summary>
    /// <param name="str">明文</param>
    /// <returns>密文</returns>
    public static string Sm2Encrypt(string str)
    {
        try
        {
            // 加密
            if (!string.IsNullOrWhiteSpace(str))
                return SM2Util.Encrypt(str);
        }
        catch
        {
            return "";
        }

        return "";
    }

    #endregion SM2

    #region Sm4

    /// <summary>
    ///     SM4解密
    /// </summary>
    /// <param name="str">密文</param>
    /// <returns>明文</returns>
    public static string Sm4Decrypt(string str)
    {
        if (!string.IsNullOrWhiteSpace(str)) // 解密
            return SM4Util.Decrypt(new SM4Util { Data = str });
        return "";
    }

    /// <summary>
    ///     SM4加密
    /// </summary>
    /// <param name="str">明文</param>
    /// <returns>密文</returns>
    public static string Sm4Encrypt(string str)
    {
        if (!string.IsNullOrWhiteSpace(str)) // 加密
            return SM4Util.Encrypt(new SM4Util { Data = str });
        return "";
    }

    #endregion Sm4
}