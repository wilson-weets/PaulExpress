import * as React from "react";
import { Redirect, Route, Switch } from "react-router-dom";
import { SandiwchList } from "./SandwichList";

export enum ERoutes {
  sandwichList = "/sandwichList"
}

export const AppRouter = () => {
  return (
    <Switch>
      <Route path={`${ERoutes.sandwichList}`} component={SandiwchList}></Route>
      <Redirect to={ERoutes.sandwichList} exact />
    </Switch>
  );
};
