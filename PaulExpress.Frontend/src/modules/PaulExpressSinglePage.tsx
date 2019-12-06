import * as React from "react";
import styled from "styled-components";
import { Card, Elevation } from "@blueprintjs/core";
import { ErrorBoundary } from "nsitools-react";
import { AppRouter, ERoutes } from "../AppRouter";
import { useHistory } from "react-router";

export const PaulExpressSinglePage: React.FunctionComponent = () => {
  const history = useHistory();
  const path = history.location.pathname;

  const CardContainer = React.useMemo(
    () =>
      styled(Card)`
        background-color: white;
        margin: 2% ${path === ERoutes.home ? "35%" : "5%"};
        transform: scale(1);
        height: 100%;
        border-radius: 40px;
        transition: width 2s, height 2s, transform 2s;
      `,
    [path]
  );

  return (
    <CardContainer elevation={Elevation.TWO}>
      <ErrorBoundary>
        <AppRouter />
      </ErrorBoundary>
    </CardContainer>
  );
};

export default PaulExpressSinglePage;
