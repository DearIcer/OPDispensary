/**
 * @description 接口
 * @license Apache License Version 2.0
 * @remarks
 * SimpleAdmin 基于 Apache License Version 2.0 协议发布，可用于商业项目，但必须遵守以下补充条款:
 * 1.请不要删除和修改根目录下的LICENSE文件。
 * 2.请不要删除和修改SimpleAdmin源码头部的版权声明。
 * 3.分发源码时候，请注明软件出处 https://gitee.com/zxzyjs/SimpleAdmin
 * 4.基于本软件的作品，只能使用 SimpleAdmin 作为后台服务，除外情况不可商用且不允许二次分发或开源。
 * 5.请不得将本软件应用于危害国家安全、荣誉和利益的行为，不能以任何形式用于非法为目的的行为不要删除和修改作者声明。
 * 6.任何基于本软件而产生的一切法律纠纷和责任，均于我司无关
 * @see https://gitee.com/zxzyjs/SimpleAdmin
 */
export type IconPrefixType = "ep" | "local" | "ant-design" | "et" | "flat-color-icons" | "eva" | "zondicons" | "uiw" | "line-md";

/** 图标选择器属性 */
export interface SelectIconProps {
  /** 图标对应的值 */
  iconValue: string;
  /** 图标选择器标题 */
  title?: string;
  /** 是否可清除 */
  clearable?: boolean;
  /** 图标选择器占位符 */
  placeholder?: string;
}

/** 图标列表信息 */
export interface SelectIconIconsInfo {
  /** 图标前缀 */
  prefix: string;
  /** 图标名称列表 */
  icons: string[];
}

/** 图标选择器tabs信息 */
export interface SelectIconTabs {
  /** tab标题 */
  label: string;
  /** 图标前缀 */
  prefix: IconPrefixType;
}
