import * as React from "react";
import { Redirect, Route, Switch } from "react-router-dom";
import { SandwichList } from "./modules/sandwich/SandwichList";
import { Home } from "./modules/Home";

export enum ERoutes {
  sandwichList = "/sandwichList",
  home = "/home"
}

export const AppRouter = () => {
  return (
    <Switch>
      <Route path={`${ERoutes.home}`} component={Home}></Route>
      <Route path={`${ERoutes.sandwichList}/:shopId`} component={SandwichList}></Route>
      <Redirect to={ERoutes.home} exact />
    </Switch>
  );
};
