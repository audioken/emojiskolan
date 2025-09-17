// import { useEffect } from "react";
// import { useBlocker } from "react-router-dom";
// import { useBoard } from "../../context/BoardContext";
import Board from "../../components/Board/Board";

function StartPage() {
  // const { timerActive } = useBoard();

  // // Blockera navigation när spel pågår
  // useBlocker(({ currentLocation, nextLocation }) => {
  //   if (timerActive && currentLocation.pathname !== nextLocation.pathname) {
  //     return !confirm("Ett spel pågår! Vill du verkligen avbryta spelet och lämna sidan?");
  //   }
  //   return false;
  // });

  return (
    <div>
      <Board />
    </div>
  );
}

export default StartPage;