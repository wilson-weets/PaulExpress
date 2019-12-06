import "normalize.css/normalize.css";
import * as React from "react";
import { useTl } from "./hooks/useTl";
import { ETLCodes } from "./locales";
import { Colors, Label } from "@blueprintjs/core";
import styled from "styled-components";
import { AppRouter } from "./AppRouter";
import { ErrorBoundary } from "nsitools-react";
import { BrowserRouter, Switch } from "react-router-dom";
import PaulExpressSinglePage from "./modules/PaulExpressSinglePage";

interface IAppProps {}

const AppContainer = styled.div`
  display: flex;
  flex: 1;
  height: 100%;
  width: 100%;
  flex-direction: column;
  background-color: #f0d576;
`;

export const App: React.FunctionComponent<IAppProps> = () => {
  const { t, tUnsafe } = useTl();

  return (
    <BrowserRouter>
      <AppContainer>
        <PaulExpressSinglePage></PaulExpressSinglePage>
      </AppContainer>
    </BrowserRouter>
  );
};
