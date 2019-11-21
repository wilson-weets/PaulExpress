import React from "react";
import { Redirect, Route, Switch } from "react-router-dom";
import { Home } from "./modules/home/home";
export enum ERoutes {
  home = "/home"
}

export const AppRouter = () => {
  return (
    <Switch>
      <Route path={`${ERoutes.home}`} component={Home}></Route>
      <Redirect to={ERoutes.home} exact />
    </Switch>
  );
};
