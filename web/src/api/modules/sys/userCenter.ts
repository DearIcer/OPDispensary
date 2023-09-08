/**
 * @description 用户个人中心接口
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
import { moduleRequest } from "@/api/request";
import { ReqId, UserCenter } from "@/api/interface";
const http = moduleRequest("/sys/userCenter/");

/** 获取用户菜单 */
export const getAuthMenuListApi = (params: ReqId) => {
  return http.get<Menu.MenuOptions[]>("loginMenu", params, { noLoading: true });
  // return authMenuList;
};

/** 设置默认模块 */
export const setDefaultModuleApi = (params: UserCenter.ResModuleDefault) => {
  http.post("setDefaultModule", params, { noLoading: true });
};

/** 修改用户密码 */
export const updatePasswordApi = () => {
  return http.get<Menu.MenuOptions[]>("loginMenu", {}, { noLoading: true });
};
