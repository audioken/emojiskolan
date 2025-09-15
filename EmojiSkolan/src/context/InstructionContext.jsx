import { createContext, useContext, useState } from "react";


const InstructionContext = createContext();

export function InstructionProvider({ children }) {
    const [message, setMessage] = useState("");

    const showMessage = (msg) => setMessage(msg);
    const clearMessage = () => setMessage("");

    return (
        <InstructionContext.Provider value={{ message, showMessage, clearMessage }}>
            {children}
        </InstructionContext.Provider>
    );
}

export function useInstruction() {
    return useContext(InstructionContext);
}