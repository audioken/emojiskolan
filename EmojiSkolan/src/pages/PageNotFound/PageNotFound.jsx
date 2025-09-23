import './PageNotFound.css';
import { useEffect } from 'react';
import { useInstruction } from '../../context/InstructionContext';
import instructionMessages from '../../utils/instructionMessages';

export default function PageNotFound() {
  const { showMessage } = useInstruction();

  useEffect(() => {
    showMessage(instructionMessages.get('pageNotFound'));
  }, []);

  return (
    <main>
      <div className="page-not-found-content">
        <h1 className="text-6xl font-bold mb-4">404</h1>
        <p className="text-lg mb-6">Sidan du letar efter finns inte.</p>
      </div>
    </main>
  );
}
