/**
 * @description  模块管理接口
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
import { ReqPage } from "@/api/interface";
export namespace Module {
  /**模块分页查询 */
  export interface Page extends ReqPage {
    title: string;
  }

  /** 单页信息 */
  export interface ModuleInfo {
    /** id */
    id: number | string;
    /** 菜单名称 */
    title: string;
    /** 菜单描述 */
    description: string;
    /** 菜单图标 */
    icon: string;
    /** 状态 */
    status: string;
    /** 排序 */
    sortCode: number;
    /** 创建时间 */
    createTime: string;
  }
}
