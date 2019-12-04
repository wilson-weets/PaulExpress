import * as React from "react";
import { Redirect, Route, Switch } from "react-router-dom";
import { SandiwchList } from "./modules/sandwich/SandwichList";
import { Home } from "./modules/Home";

export enum ERoutes {
  sandwichList = "/sandwichList",
  home = "/home"
}

export const AppRouter = () => {
  return (
    <Switch>
      <Route path={`${ERoutes.home}`} component={Home}></Route>
      <Route path={`${ERoutes.sandwichList}/:shopId`} component={SandiwchList}></Route>
      <Redirect to={ERoutes.home} exact />
    </Switch>
  );
};
