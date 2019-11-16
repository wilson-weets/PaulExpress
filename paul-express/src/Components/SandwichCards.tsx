//TODO: Le composant est pas ouf, il faudra probablement le refaire from scratch, je le laisse pour l'exemple et pour comparer par la suite, voir comment j'aurai pu l'améliorer
import * as React from "react";
import { Sandwich } from "../sandwich";
import styled, { css } from "styled-components";
import { Checkbox } from "@blueprintjs/core";

interface ISandwichCardProps {
  sandwich: Sandwich; //later will be an array of sandwich DTO
}

const Container = styled.div`
  display: flex;
  flex-direction: column;
  flex: 1;
  border: 1px solid gray;
`;
const ColumnContainer = styled.div`
  flex: 1;
  display: flex;
  justify-content: space-between;
  flex-direction: row;
`;

export const SandwichCard: React.FunctionComponent<ISandwichCardProps> = ({ sandwich }) => {
  let s = "";
  sandwich.ingredients.map(i => (s !== "" ? (s = s + ", " + i) : (s = i)));
  return (
    <Container>
      <ColumnContainer>
        <div style={{ paddingLeft: "1rem" }}>{sandwich.name}</div>
        <div style={{ paddingRight: "1rem" }}>{sandwich.price}€</div>
      </ColumnContainer>
      <ColumnContainer>
        <div style={{ paddingLeft: "1rem" }}>{s}</div>
      </ColumnContainer>
      <ColumnContainer>
        <div style={{}}>
          <Checkbox></Checkbox>
        </div>
      </ColumnContainer>
    </Container>
  );
};
