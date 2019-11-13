import { LOCATION_CHANGE } from "connected-react-router";
import { ActionType } from "typesafe-actions";

export const allActions = {
  //search: searchAction,
};

export default allActions;

export type RootAction = ActionType<typeof allActions>;
