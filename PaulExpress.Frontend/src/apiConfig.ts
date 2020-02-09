import { Configuration } from "./api";

export let baseUrl = process.env.REACT_APP_API_URL;
if (baseUrl === "~") {
  const hostUrl = window.location.href.split("/");
  baseUrl = hostUrl[0] + "//" + hostUrl[2];
}

export const apiConfiguration = (token?: string) => {
  const configuration = {
    basePath: baseUrl,
    apiKey: () => {
      if (token) {
        return `Bearer ${token}`;
      } else {
        return "";
      }
    }
  };
  return new Configuration(configuration);
};

export const setApiUrl = (u: string) => {
  console.log("Set Api url with " + u);
  baseUrl = u;
};
