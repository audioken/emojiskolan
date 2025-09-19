import { createContext, useContext, useRef, useState } from 'react';

const MultiFormContext = createContext();

export function MultiFormProvider({ children }) {
  const formRefs = useRef({});
  const [formValid, setFormValid] = useState({});

  const setFormRef = (name, ref) => {
    formRefs.current[name] = ref;
  };

  const setFormValidStatus = (name, valid) => {
    setFormValid((prev) => {
      if (prev[name] === valid) return prev;
      return { ...prev, [name]: valid };
    });
  };

  const submitForm = (name) => {
    const ref = formRefs.current[name];
    if (ref && ref.current) {
      ref.current.requestSubmit();
    }
  };

  return (
    <MultiFormContext.Provider value={{ setFormRef, submitForm, setFormValidStatus, formValid }}>
      {children}
    </MultiFormContext.Provider>
  );
}

export function useMultiForm() {
  return useContext(MultiFormContext);
}
