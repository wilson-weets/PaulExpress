import * as React from "react";
import styled from "styled-components";
import { Button, Card, Elevation } from "@blueprintjs/core";
import { useTl } from "../hooks/useTl";
import { ETLCodes } from "../locales";
import { Redirect, useHistory } from "react-router-dom";
import { ERoutes } from "../AppRouter";

const Logo = styled.img`
  display: flex;
  margin: auto;
`;

const ButtonDiv = styled.div`
  display: flex;
  flex-direction: column;
  margin: auto;
  justify-content: center;
  align-items: center;
`;

const PEButton = styled(Button)`
  background-color: #f2b978 !important;
  color: black;
  margin: 8px;
  width: 50% !important;

  &:hover {
    background-color: #e59232 !important;
  }
`;

export const Home: React.FunctionComponent = () => {
  const logo = require("../assets/logo.png");
  const { t } = useTl();
  const history = useHistory();

  const handleClick = () => {
    history.push(`${ERoutes.sandwichList}/1`);
  };

  return (
    <div>
      <Logo src={logo} />
      <ButtonDiv>
        <PEButton text={t(ETLCodes.Order)} large minimal onClick={handleClick}></PEButton>
        <PEButton text={t(ETLCodes.Administration)} large minimal></PEButton>
        <PEButton text={t(ETLCodes.CurrentOrder)} large minimal></PEButton>
      </ButtonDiv>
    </div>
  );
};

export default Home;
