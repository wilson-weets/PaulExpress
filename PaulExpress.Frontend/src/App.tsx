import "normalize.css/normalize.css";
import * as React from "react";
import { useTl } from "./hooks/useTl";
import { ETLCodes } from "./locales";
import { Colors, Label } from "@blueprintjs/core";
import styled from "styled-components";
import { AppRouter } from "./AppRouter";
import { ErrorBoundary } from "nsitools-react";
import { BrowserRouter } from "react-router-dom";

interface IAppProps {}

const AppContainer = styled.div<{ isDark: boolean }>`
  display: flex;
  flex: 1;
  height: 100%;
  width: 100%;
  flex-direction: column;
  background-color: ${props => (props.isDark ? Colors.DARK_GRAY2 : Colors.LIGHT_GRAY3)};
`;

export const App: React.FunctionComponent<IAppProps> = props => {
  const { t, tUnsafe } = useTl();

  return (
    <BrowserRouter>
      <AppContainer isDark={false}>
        <Label>
          App works! hello {t(ETLCodes.BONJOURWILSON)} <br /> {tUnsafe("FROMSERVER")}
        </Label>
        <ErrorBoundary>
          <AppRouter />
        </ErrorBoundary>
      </AppContainer>
    </BrowserRouter>
  );
};
