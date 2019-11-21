import "whatwg-fetch";
import * as React from "react";
import { Provider } from "react-redux";
import { store, history } from "./redux/store";
import { ConnectedRouter } from "connected-react-router";
import App, { IAppProps } from "./App";

interface IRootProps extends IAppProps {}

export const Root: React.FunctionComponent<IRootProps> = props => {
  return (
    <Provider store={store}>
      <ConnectedRouter history={history}>
        <App {...props} />
      </ConnectedRouter>
    </Provider>
  );
};
