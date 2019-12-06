import * as React from "react";
import { SandwichDto } from "../../../api/models/SandwichDto";
import styled from "styled-components";
import { SelectBox, CheckboxInputField } from "nsitools-react";
import { Checkbox } from "@blueprintjs/core";

interface ISandwichCardProps {
  sandwich: SandwichDto;
  style?: React.CSSProperties;
}

const Container = styled.div`
  display: flex;
  flex-direction: Row;
  justify-content: space-between;
  border: solid darkgrey 1px;
  border-radius: 5px;
  padding: 0.5rem;
  background-color: white;
  min-width: 200px;
`;

export const SandwichCard: React.FunctionComponent<ISandwichCardProps> = ({ sandwich, style }) => {
  return (
    <Container style={style}>
      <div>
        <div>{sandwich!.name}</div>
        <div style={{ paddingTop: "0.5rem" }}>{sandwich!.ingredients}</div>
      </div>
      <div>
        <div>{sandwich.unitPrice && sandwich.unitPrice + "€"}</div>
        <Checkbox style={{ float: "right", paddingTop: "0.5rem" }} />
      </div>
    </Container>
  );
};
