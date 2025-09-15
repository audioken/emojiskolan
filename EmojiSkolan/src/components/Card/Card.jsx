import "./Card.css";

function Card({ card, onClick }) {
  const isMatched = card.isMatched;
  const isColored = card.isMatched && card.isGameWon;
  return (
    <div
      className={`card${card.isTurnedOver ? " flipped" : ""}${isMatched ? " matched" : ""}${isColored ? " " + card.matchColor : ""}${card.flashWrong ? " flash-wrong" : ""}`}
      onClick={onClick}
    >
      <div className="card-inner">
  <div className={`card-front${!card.isEmoji ? " long-content" : ""}${card.flashWrong ? " flash-wrong" : ""}`}>
          {card.isTurnedOver || isMatched ? card.content : ""}
        </div>
        <div className="card-back">❓</div>
      </div>
    </div>
  );
}

export default Card;
