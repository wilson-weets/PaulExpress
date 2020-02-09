import { useApiEffect, showSuccess, showError } from "nsitools-react";
import * as React from "react";
import { useTl } from ".";
import { useHistory } from "react-router";
import { ETLCodes } from "../locales";
import { ErrorDetails } from "../api";
import { useDialog } from "../contexts";

export interface IUseCrudApiOptions<T> {
  getApiFn: () => Promise<T> | T;
  saveApiFn: (data: T) => Promise<T> | T;
  deleteApiFn: (data: T) => Promise<any> | any;
  onSavedRoute?: (data: T) => string;
  onDeletedRoute?: (data: T) => string;
  successMessage?: string;
  deletedMessage?: string;
}

export function useCrudApi<T>(options: IUseCrudApiOptions<T>) {
  const { getApiFn, saveApiFn, deleteApiFn, onSavedRoute, onDeletedRoute, successMessage, deletedMessage } = options;
  const { t, tUnsafe } = useTl();
  const { showDialog } = useDialog();

  const history = useHistory();

  const [data, loading, , refresh, setData] = useApiEffect<T>(getApiFn);

  const [saving, setSaving] = React.useState(false);

  const finalSuccessMessage = React.useMemo(() => successMessage || t(ETLCodes.SaveSuccess), [successMessage, t]);

  const manageError = React.useCallback(
    (error: any) => {
      if (error instanceof Response) {
        error.json().then((d: ErrorDetails) => {
          showError(tUnsafe(`BackendError_${d.errorCode}`));
        });
      } else {
        showError(t(ETLCodes.Error));
      }
    },
    [t, tUnsafe]
  );

  const saveItem = React.useCallback(
    async (values: T) => {
      try {
        setSaving(true);
        const saved: T = await saveApiFn(values);
        showSuccess(finalSuccessMessage);
        setData(saved);
        setTimeout(() => {
          if (onSavedRoute) {
            history.push(onSavedRoute(saved));
          }
        }, 0);
      } catch (error) {
        manageError(error);
      }
      setSaving(false);
    },
    [finalSuccessMessage, history, manageError, onSavedRoute, saveApiFn, setData]
  );

  const finalDeleteMessage = React.useMemo(() => deletedMessage || t(ETLCodes.DeleteSuccess), [deletedMessage, t]);

  const [deleting, setDeleting] = React.useState(false);
  const deleteItem = React.useCallback(() => {
    showDialog({
      message: t(ETLCodes.DeleteConfirmationMessage),
      title: t(ETLCodes.DeleteDialogTitle),
      onConfirmed: async () => {
        try {
          setDeleting(true);
          await deleteApiFn(data);
          setTimeout(() => {
            if (onDeletedRoute) {
              history.push(onDeletedRoute(data));
            }
          }, 0);
          showSuccess(finalDeleteMessage);
        } catch (error) {
          manageError(error);
        }
        setDeleting(false);
      }
    });
  }, [data, deleteApiFn, finalDeleteMessage, history, manageError, onDeletedRoute, showDialog, t]);

  return {
    data,
    loading,
    setData,
    saveItem,
    saving,
    deleteItem,
    deleting,
    refresh
  };
}
