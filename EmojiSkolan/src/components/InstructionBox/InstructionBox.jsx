import "./InstructionBox.css";
import { useInstruction } from "../../context/InstructionContext";

const InstructionBox = ({ title }) => {
  const { message } = useInstruction();

  return (
    <div className="instruction-box">
      <div className="instruction-box-content">{message}</div>
    </div>
  );
};

export default InstructionBox;
