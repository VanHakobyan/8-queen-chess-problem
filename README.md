# 8 queen chess problem
<p align="center">
<img src="http://mathworld.wolfram.com/images/eps-gif/QueensMax_800.gif">
</p>
<p>The <b>eight queens puzzle</b> is the problem of placing eight <a href="https://en.wikipedia.org/wiki/Chess" title="Chess">chess</a> <a href="https://en.wikipedia.org/wiki/Queen_(chess)" title="Queen (chess)">queens</a> on an 8×8 chessboard so that no two queens threaten each other. Thus, a solution requires that no two queens share the same row, column, or diagonal. The eight queens puzzle is an example of the more general <b><i>n</i> queens problem</b> of placing <i>n</i> non-attacking queens on an <i>n</i>×<i>n</i> chessboard, for which solutions exist for all natural numbers <i>n</i> with the exception of <i>n</i>=2 and <i>n</i>=3.<sup id="cite_ref-1" class="reference"><a href="#cite_note-1"></a></sup></p><br>


* Solution

<p>The eight queens puzzle has 92 <b>distinct</b> solutions. If solutions that differ only by <a href="https://en.wikipedia.org/wiki/Symmetry" title="Symmetry">symmetry operations</a> (rotations and reflections) of the board are <a href="https://en.wikipedia.org/wiki/Up_to" title="Up to">counted as one</a>, the puzzle has 12 <b>fundamental</b> solutions.</p>

A fundamental solution usually has eight variants (including its original form) obtained by rotating 90, 180, or 270° and then reflecting each of the four rotational variants in a mirror in a fixed position. However, should a solution be equivalent to its own 90° rotation (as happens to one solution with five queens on a 5x5 board), that fundamental solution will have only two variants (itself and its reflection).
<br>


```C#

//first
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum = sum + board[i, j];
                }
                if (sum > 1)
                {
                    return false;
                }
            }


            //second
            for (int i = 0, j = N - 2; j >= 0; j--)
            {
                int sum = 0;
                for (int p = i, q = j; q < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }

```

Should a solution be equivalent to its own 180° rotation (but not to its 90° rotation), it will have four variants (itself and its reflection, its 90° rotation and the reflection of that). It is not possible for a solution to be equivalent to its own reflection (except at n=1) because that would require two queens to be facing each other. (For n-queen problem's solution to be equivalent to its own mirror-image solution, the solution needs to be symmetrical by the center of the board either horizontally or vertically. Then, two queens would be facing each other, making it not a solution. ) Of the 12 fundamental solutions to the problem with eight queens on an 8x8 board, exactly one is equal to its own 180° rotation, and none is equal to its 90° rotation; thus, the number of distinct solutions is 11*8 + 1*4 = 92 (where the 8 is derived from four 90° rotational positions and their reflections, and the 4 is derived from two 180° rotational positions and their reflections).

<br><br><br><br>

<p align="center">
<img src="https://github.com/VanHakobyan/8-queen-chess-problem/blob/master/GIFchess.gif">
</p>



