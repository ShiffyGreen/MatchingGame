const buttonValues = [
    'A', 'A', 'B', 'B', 'C', 'C',
    'D', 'D', 'E', 'E', 'F', 'F',
    'G', 'G', 'H', 'H', 'I', 'I',
    'J', 'J', 'K', 'K', 'L', 'L',
    'M', 'M', 'N', 'N', 'O', 'O',
    'P', 'P', 'Q', 'Q', 'R', 'R'
];
let firstSelection = null;
let secondSelection = null;
let lockBoard = false;
let matchedPairs = 0;
let currentPlayer = 1;
let player1Matches = 0;
let player2Matches = 0;
function shuffle(array) {
    for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
}
function setupGame() {
    shuffle(buttonValues);
    const buttons = document.querySelectorAll('.cards');
    buttons.forEach((button, index) => {
        button.textContent = '';
        button.dataset.value = buttonValues[index];
        button.disabled = false;
        button.style.backgroundColor = '';
        button.style.opacity = '1';
        button.style.pointerEvents = 'auto';
        button.classList.remove('btn-warning');
        button.addEventListener('click', handleButtonClick);
    });
    currentPlayer = 1;
    updateTurnLabel();
    const turnLabel = document.getElementById('turnLabel');
    if (turnLabel)
        turnLabel.style.display = 'block';
    player1Matches = 0;
    player2Matches = 0;
    updateMatchCounts();
}
function handleButtonClick(event) {
    if (lockBoard)
        return;
    const button = event.target;
    button.textContent = button.dataset.value;
    button.classList.add('btn-warning');
    if (!firstSelection) {
        firstSelection = button;
        return;
    }
    if (firstSelection === button) {
        return;
    }
    secondSelection = button;
    lockBoard = true;
    checkForMatch();
}
function checkForMatch() {
    if (!firstSelection || !secondSelection)
        return;
    if (firstSelection.dataset.value === secondSelection.dataset.value) {
        matchedPairs++;
        if (currentPlayer === 1) {
            player1Matches++;
        }
        else {
            player2Matches++;
        }
        updateMatchCounts();
        firstSelection.style.backgroundColor = 'red';
        secondSelection.style.backgroundColor = 'red';
        setTimeout(() => {
            if (firstSelection && secondSelection) {
                firstSelection.style.opacity = '0';
                firstSelection.style.pointerEvents = 'none';
                secondSelection.style.opacity = '0';
                secondSelection.style.pointerEvents = 'none';
                resetSelections(true);
                if (matchedPairs === buttonValues.length / 2) {
                    if (player1Matches === player2Matches) {
                        updateTurnLabel('It\'s a tie!');
                    }
                    else {
                        const winner = player1Matches > player2Matches ? 'Player 1' : 'Player 2';
                        updateTurnLabel(`${winner} wins with ${Math.max(player1Matches, player2Matches)} matches!`);
                    }
                }
            }
        }, 2000);
    }
    else {
        setTimeout(() => {
            if (firstSelection && secondSelection) {
                firstSelection.textContent = '';
                secondSelection.textContent = '';
                firstSelection.classList.remove('btn-warning');
                secondSelection.classList.remove('btn-warning');
                resetSelections(false);
            }
        }, 1000);
    }
}
function resetSelections(isMatch) {
    firstSelection = null;
    secondSelection = null;
    lockBoard = false;
    if (!isMatch) {
        currentPlayer = currentPlayer === 1 ? 2 : 1;
    }
    updateTurnLabel();
}
function updateTurnLabel(message) {
    const turnLabel = document.getElementById('turnLabel');
    if (!turnLabel)
        return;
    turnLabel.textContent = message || `Current Turn: Player ${currentPlayer}`;
}
function updateMatchCounts() {
    const player1Element = document.getElementById('player1Matches');
    const player2Element = document.getElementById('player2Matches');
    if (player1Element)
        player1Element.textContent = player1Matches.toString();
    if (player2Element)
        player2Element.textContent = player2Matches.toString();
}
function clearBoard() {
    matchedPairs = 0;
    player1Matches = 0;
    player2Matches = 0;
    updateMatchCounts();
    const buttons = document.querySelectorAll('.cards');
    buttons.forEach(button => {
        button.textContent = '';
        button.style.opacity = '1';
        button.style.pointerEvents = 'auto';
        button.style.backgroundColor = '';
        button.classList.remove('btn-warning');
    });
    resetSelections(false);
}
document.addEventListener('DOMContentLoaded', () => {
    const playButton = document.getElementById('playButton');
    if (playButton) {
        playButton.addEventListener('click', () => {
            playButton.textContent = 'Play';
            if (matchedPairs > 0) {
                clearBoard();
            }
            setupGame();
        });
    }
});
//# sourceMappingURL=MatchingGameTypeScript.js.map