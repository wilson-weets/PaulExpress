import * as React from "react";
import { UserDto, AuthenticateDto, UsersApi } from "../api";
import { apiConfiguration } from "../apiConfig";
import { useLocalStorage } from "../hooks";

interface IAuthProviderProps {}

interface IAuthContext {
  login: (auth: AuthenticateDto) => Promise<void>;
  logout: () => void;
  isLoading: boolean;
  user?: UserDto;
}

const AuthContext = React.createContext<IAuthContext>(null);

const LOCALSTORAGE_AUTH_KEY = "user";

const AuthProvider: React.FunctionComponent<IAuthProviderProps> = ({ children }) => {
  // Load from localstorage
  const userApi = React.useMemo(() => new UsersApi(apiConfiguration()), []);
  const [isLoading, setIsLoading] = React.useState(false);

  const [storedUser, setStoredUser] = useLocalStorage<UserDto>(LOCALSTORAGE_AUTH_KEY, null);

  const [user, setUser] = React.useState(storedUser);

  const login = async (auth: AuthenticateDto) => {
    setIsLoading(true);
    const userFromBackend = await userApi.usersAuthenticatePost({ AuthenticateDto: auth });
    if (userFromBackend) {
      setStoredUser(userFromBackend);
    }
    setIsLoading(false);
    setUser(userFromBackend);
  };

  const logout = () => {
    setUser(null);
    localStorage.removeItem(LOCALSTORAGE_AUTH_KEY);
  };

  return <AuthContext.Provider value={{ login, logout, user, isLoading }}>{children}</AuthContext.Provider>;
};

const useAuth = () => React.useContext(AuthContext);

export { AuthProvider, useAuth };
