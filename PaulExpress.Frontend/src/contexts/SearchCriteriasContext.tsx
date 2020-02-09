import * as React from "react";

type CriteriaRouteType = {
  [route: string]: any;
};

interface ISearchCriteriaContext {
  setCriterias: (route: string, criteria: object) => void;
  criterias: CriteriaRouteType;
}
const SearchCriteriaContext = React.createContext<ISearchCriteriaContext>(null);

export const SearchCriteriaProvider: React.FunctionComponent = ({ children }) => {
  const [routeCriteria, setRouteCriteria] = React.useState<CriteriaRouteType>({});

  const setCriterias = React.useCallback(
    (route: string, sObj: any) => {
      const origString = JSON.stringify(routeCriteria[route]);
      const objString = JSON.stringify(sObj);
      if (origString !== objString) {
        setRouteCriteria(c => ({
          ...c,
          [route]: sObj
        }));
      }
    },
    [routeCriteria]
  );

  return (
    <SearchCriteriaContext.Provider value={{ criterias: routeCriteria, setCriterias }}>
      {children}
    </SearchCriteriaContext.Provider>
  );
};

export const useSearchCriteriaContext = () => React.useContext(SearchCriteriaContext);
