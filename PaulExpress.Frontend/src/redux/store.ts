import createSagaMiddleware from "@redux-saga/core";
import { routerMiddleware } from "connected-react-router";
import { createHashHistory } from "history";
import { applyMiddleware, createStore } from "redux";
import { composeWithDevTools } from "redux-devtools-extension";
import { persistReducer, persistStore } from "redux-persist";
import storage from "redux-persist/lib/storage";
import thunk from "redux-thunk";

import rootReducer from "./rootReducer";
import rootSaga from "./rootSaga";
import autoMergeLevel2 from "redux-persist/es/stateReconciler/autoMergeLevel2";

const persistConfig = {
  key: "root",
  storage,
  stateReconcilier: autoMergeLevel2,
  whitelist: ["userPreferences"]
};
const sagaMiddleware = createSagaMiddleware();

export const history = createHashHistory({
  basename: "", // The base URL of the app (see below)
  hashType: "slash", // The hash type to use (see below)
  // A function to use to confirm navigation with the user (see below)
  getUserConfirmation: (message, callback) => callback(window.confirm(message))
});

// expo

const composeEnhancers = composeWithDevTools({});

const middleWares = [thunk, routerMiddleware(history), sagaMiddleware];
const persistedReducer = persistReducer(persistConfig, rootReducer(history));

export const store = createStore(persistedReducer, composeEnhancers(applyMiddleware(...middleWares)));

sagaMiddleware.run(rootSaga);
export const persistor = persistStore(store);
