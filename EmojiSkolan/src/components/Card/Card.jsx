import "./Card.css";

function Card({ card, onClick }) {
  const isMatched = card.isMatched;
  const isColored = card.isMatched && card.isGameWon;
  
  // Simple length-based text sizing
  const getTextClasses = () => {
    if (card.isEmoji) return "";
    
    const textLength = card.content.length;
    let classes = " text-content";
    
    if (textLength > 12) {
      classes += " very-long-text";
    } else if (textLength > 8) {
      classes += " long-text";
    }
    // Short text (<=8 chars) gets default 1rem size
    
    return classes;
  };
  
  return (
    <div
      className={`card${card.isTurnedOver ? " flipped" : ""}${isMatched ? " matched" : ""}${isColored ? " " + card.matchColor : ""}${card.flashWrong ? " flash-wrong" : ""}`}
      onClick={onClick}
    >
      <div className="card-inner">
        <div className={`card-front${getTextClasses()}${card.flashWrong ? " flash-wrong" : ""}`}>
          {card.isTurnedOver || isMatched ? card.content : ""}
        </div>
        <div className="card-back">❓</div>
      </div>
    </div>
  );
}

export default Card;
