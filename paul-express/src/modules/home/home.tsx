import * as React from "react";
import { SandwichCard } from "../../Components/SandwichCards";
import styled from "styled-components";
import { Button, Intent } from "@blueprintjs/core";
import { iconClass, INTENT_PRIMARY } from "@blueprintjs/core/lib/esm/common/classes";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBicycle } from "@fortawesome/free-solid-svg-icons";
import { StyledCard } from "nsitools-react";

interface IHomeProps {}
//TODO: improve this shit plz
//looks like shit atm, need to style the buttons and change flex

const Container = styled.div`
  min-height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
`;

const ImgContainer = styled.div`
  display: flex;
  flex-direction: Column;
  flex: 0.05;
  align-self: center;
`;

const ButtonContainer = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  flex: 1;
  flex-grow: 1;
`;

export const Home: React.FunctionComponent<IHomeProps> = props => {
  return (
    <Container>
      <ImgContainer>
        <div>
          <img src={require("../../Ressources/Images/logo_v1.png")} alt="Paul Express's logo" />
        </div>
      </ImgContainer>
      <ButtonContainer>
        <Button intent={Intent.PRIMARY} icon={<FontAwesomeIcon icon={faBicycle} />} text="Commander"></Button>
        <Button intent={Intent.PRIMARY} text="Commandes antérieures"></Button>
        <Button intent={Intent.PRIMARY} text="Comande en cours"></Button>
      </ButtonContainer>
    </Container>
  );
};
