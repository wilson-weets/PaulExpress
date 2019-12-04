import * as React from "react";
import { SandwichDto } from "../../api/models/SandwichDto";
import styled from "styled-components";

interface ISandwichCardProps {
  sandwich: SandwichDto;
}

const Container = styled.div`
  display: flex;
`;

export const SandwichCard: React.FunctionComponent<ISandwichCardProps> = ({ sandwich }) => {
  return <Container>SandwichCard works!</Container>;
};
