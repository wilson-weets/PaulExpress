import * as React from "react";
import { SandwichCard } from "../../Components/SandwichCards";

interface IHomeProps {}

export const Home: React.FunctionComponent<IHomeProps> = props => {
  return (
    <SandwichCard
      sandwich={{ name: "Frenchy", price: 3.8, ingredients: ["Brie", "Beurre", "Noix", "Confit de figue"] }}
    />
  );
};
