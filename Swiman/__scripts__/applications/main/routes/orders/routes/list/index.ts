﻿import List from "./List";
import { loadReducer } from "./reducer";
export const loadRoutes = (store) => {
    return {
        path: 'list',
        getComponent: (partialNextState, callback) => {
            loadReducer(store);
            callback(null, List);
        }
    }
}