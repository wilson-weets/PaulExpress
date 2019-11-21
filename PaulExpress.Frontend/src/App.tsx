import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { AppRouter } from "./AppRouter";

export interface IAppProps {}

const App: React.FC = () => {
  return <AppRouter />;
};
export default App;
