import * as React from "react";
import { IButtonProps } from "@blueprintjs/core";

export type DialogResult = "yes" | "no" | "ok" | "cancel";
export type DialogResultButtonType = Omit<IButtonProps, "onClick"> & { resultType: DialogResult };
type ConfirmDialogData = {
  title?: string;
  buttons?: Array<DialogResultButtonType>;
  message: string;
  onDialogClosed?: (result: DialogResult) => void;
  onConfirmed?: () => void;
};

interface IDialogContext {
  showDialog: (data: ConfirmDialogData) => void;
  hideDialog: (result: DialogResult) => void;
  dialogData: Omit<ConfirmDialogData, "onDialogClosed">;
}

const DialogContext = React.createContext<IDialogContext>(null);

const DialogProvider: React.FunctionComponent = ({ children }) => {
  const [dialogData, setDialogData] = React.useState<ConfirmDialogData>(null);

  const showDialog = React.useCallback(
    (data: ConfirmDialogData) => {
      setDialogData(data);
    },
    [setDialogData]
  );

  const hideDialog = React.useCallback(
    (result: DialogResult) => {
      const { onDialogClosed, onConfirmed } = dialogData;
      setDialogData(null);
      if (onDialogClosed) onDialogClosed(result);
      if ((result === "ok" || result === "yes") && onConfirmed) {
        onConfirmed();
      }
    },
    [dialogData]
  );

  return <DialogContext.Provider value={{ showDialog, dialogData, hideDialog }}>{children}</DialogContext.Provider>;
};

const useDialog = () => React.useContext(DialogContext);

export { DialogProvider, useDialog };
