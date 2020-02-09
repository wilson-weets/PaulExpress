import * as React from "react";
import { Configuration } from "../api";

import { useAuth } from "../contexts/AuthContext";
import { apiConfiguration } from "../apiConfig";

export function useApiService<T>(type: new (configuration: Configuration) => T): T {
  const { user } = useAuth();
  return React.useMemo(() => new type(apiConfiguration(user?.token)), [type, user]);
}
