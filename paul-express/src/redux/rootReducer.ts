import { combineReducers } from "redux";
import { StateType } from "typesafe-actions";
import { connectRouter } from "connected-react-router";

const rootReducer = (history: any) =>
  combineReducers({
    router: connectRouter(history)
  });
export default rootReducer;

export type RootState = StateType<ReturnType<typeof rootReducer>>;
