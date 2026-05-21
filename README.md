# BackendAssigmentPearStu# Backend Assigment Pearfiction Studios

## Overview

A C# console application that simulates a slot machine using multiple symbol bands. This version includes randomized spins and generates a 3×5 symbol grid, calculating all possible winning combinations. This project simulates a slot machine using symbol bands, each containing a sequence of symbols. When the slot machine spins, it randomly selects positions from each band to generate the visible grid. Wins are calculated using a "ways to win" system, considering all combinations of matching symbols across consecutive columns.

## Features
+ Supports a 5-column, 3-row slot grid.
+ Uses symbol bands to randomize spins and create realistic slot behavior.
+ Defines symbol payouts via a configurable pay table.
+ Calculates all possible winning combinations across consecutive columns.
+ Displays detailed win information including:
  + Positions in the grid
  + Symbol type
  + Number of consecutive columns
  + Payout value
+ Prints stop positions for debugging and transparency.

## Code Structure
- Symbols: Enum representing all slot symbols (sym1 to sym8).
- SlotMachine: Core class for slot mechanics:
  - Bands: band1 … band5 — arrays representing symbol sequences.
  - Grid Properties: symbGrid (3×5)
  - Pay Table: Dictionary mapping symbols to payout arrays.
  - Methods:
    - SpinGrid() — Randomly selects symbols from each band to fill the grid.
    - CalculateWin() — Calculates total winnings and prints all winning combinations.
    - FindCombinations() — Recursive method generating all possible row combinations per winning line.
    - GetRandomIndex() — Selects a random index for a band.

## Improvements
- Dynamic Band & Grid Sizes: Allow configurable grid sizes and dynamically generate bands, making the machine easily adaptable for different layouts.