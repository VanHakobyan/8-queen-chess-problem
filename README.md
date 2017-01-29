# 8 queen chess problem
<p align="center">
<img src="http://mathworld.wolfram.com/images/eps-gif/QueensMax_800.gif">
</p>
<p>The <b>eight queens puzzle</b> is the problem of placing eight <a href="https://en.wikipedia.org/wiki/Chess" title="Chess">chess</a> <a href="https://en.wikipedia.org/wiki/Queen_(chess)" title="Queen (chess)">queens</a> on an 8×8 chessboard so that no two queens threaten each other. Thus, a solution requires that no two queens share the same row, column, or diagonal. The eight queens puzzle is an example of the more general <b><i>n</i> queens problem</b> of placing <i>n</i> non-attacking queens on an <i>n</i>×<i>n</i> chessboard, for which solutions exist for all natural numbers <i>n</i> with the exception of <i>n</i>=2 and <i>n</i>=3.<sup id="cite_ref-1" class="reference"><a href="#cite_note-1"></a></sup></p>


### Solotion

<p>The eight queens puzzle has 92 <b>distinct</b> solutions. If solutions that differ only by <a href="https://en.wikipedia.org/wiki/Symmetry" title="Symmetry">symmetry operations</a> (rotations and reflections) of the board are <a href="https://en.wikipedia.org/wiki/Up_to" title="Up to">counted as one</a>, the puzzle has 12 <b>fundamental</b> solutions.</p>

<p>A fundamental solution usually has eight variants (including its original form) obtained by rotating 90, 180, or 270° and then reflecting each of the four rotational variants in a mirror in a fixed position. However, should a solution be equivalent to its own 90° rotation (as happens to one solution with five queens on a 5x5 board), that fundamental solution will have only two variants (itself and its reflection). Should a solution be equivalent to its own 180° rotation (but not to its 90° rotation), it will have four variants (itself and its reflection, its 90° rotation and the reflection of that). It is not possible for a solution to be equivalent to its own reflection (except at n=1) because that would require two queens to be facing each other. (For n-queen problem's solution to be equivalent to its own mirror-image solution, the solution needs to be symmetrical by the center of the board either horizontally or vertically. Then, two queens would be facing each other, making it not a solution. ) Of the 12 fundamental solutions to the problem with eight queens on an 8x8 board, exactly one is equal to its own 180° rotation, and none is equal to its 90° rotation; thus, the number of distinct solutions is 11*8 + 1*4 = 92 (where the 8 is derived from four 90° rotational positions and their reflections, and the 4 is derived from two 180° rotational positions and their reflections).</p>

<div>
<table class="multicol" role="presentation" style="border-collapse: collapse; padding: 0; border: 0; background:transparent; width:100%;">
<tbody><tr>
<td style="text-align: left; vertical-align: top;">
<div class="thumb tright" style="clear:right;text-align:center;max-width:222px">
<div style="line-height:130%"></div>
<div class="thumbinner" style="width:214px">
<table cellpadding="0" cellspacing="0" style="background:white;font-size:88%;border:1px #b0b0b0 solid;padding:0;margin:auto">
<tbody><tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
<td colspan="8" rowspan="8" style="padding:0;vertical-align:inherit">
<div class="chess-board" style="position:relative"><img alt="Chessboard480.svg" src="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/176px-Chessboard480.svg.png" width="176" height="176" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/264px-Chessboard480.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/352px-Chessboard480.svg.png 2x" data-file-width="480" data-file-height="480">
<div style="position:absolute;z-index:3;top:0px;left:66px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="d8 white queen"><img alt="d8 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:22px;left:132px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="g7 white queen"><img alt="g7 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:44px;left:44px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="c6 white queen"><img alt="c6 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:66px;left:154px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="h5 white queen"><img alt="h5 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:88px;left:22px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="b4 white queen"><img alt="b4 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:110px;left:88px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="e3 white queen"><img alt="e3 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:132px;left:0px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="a2 white queen"><img alt="a2 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:154px;left:110px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="f1 white queen"><img alt="f1 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
</div>
</td>
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
</tr>
<tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
</tbody></table>
<div class="thumbcaption">Solution 1</div>
</div>
</div>
</td>
<td style="text-align: left; vertical-align: top;">
<div class="thumb tright" style="clear:right;text-align:center;max-width:222px">
<div style="line-height:130%"></div>
<div class="thumbinner" style="width:214px">
<table cellpadding="0" cellspacing="0" style="background:white;font-size:88%;border:1px #b0b0b0 solid;padding:0;margin:auto">
<tbody><tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
<td colspan="8" rowspan="8" style="padding:0;vertical-align:inherit">
<div class="chess-board" style="position:relative"><img alt="Chessboard480.svg" src="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/176px-Chessboard480.svg.png" width="176" height="176" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/264px-Chessboard480.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/352px-Chessboard480.svg.png 2x" data-file-width="480" data-file-height="480">
<div style="position:absolute;z-index:3;top:0px;left:88px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="e8 white queen"><img alt="e8 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:22px;left:22px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="b7 white queen"><img alt="b7 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:44px;left:66px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="d6 white queen"><img alt="d6 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:66px;left:132px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="g5 white queen"><img alt="g5 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:88px;left:44px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="c4 white queen"><img alt="c4 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:110px;left:154px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="h3 white queen"><img alt="h3 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:132px;left:110px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="f2 white queen"><img alt="f2 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:154px;left:0px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="a1 white queen"><img alt="a1 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
</div>
</td>
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
</tr>
<tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
</tbody></table>
<div class="thumbcaption">Solution 2</div>
</div>
</div>
</td>
<td style="text-align: left; vertical-align: top;">
<div class="thumb tright" style="clear:right;text-align:center;max-width:222px">
<div style="line-height:130%"></div>
<div class="thumbinner" style="width:214px">
<table cellpadding="0" cellspacing="0" style="background:white;font-size:88%;border:1px #b0b0b0 solid;padding:0;margin:auto">
<tbody><tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
<td colspan="8" rowspan="8" style="padding:0;vertical-align:inherit">
<div class="chess-board" style="position:relative"><img alt="Chessboard480.svg" src="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/176px-Chessboard480.svg.png" width="176" height="176" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/264px-Chessboard480.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/352px-Chessboard480.svg.png 2x" data-file-width="480" data-file-height="480">
<div style="position:absolute;z-index:3;top:0px;left:66px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="d8 white queen"><img alt="d8 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:22px;left:22px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="b7 white queen"><img alt="b7 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:44px;left:132px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="g6 white queen"><img alt="g6 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:66px;left:44px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="c5 white queen"><img alt="c5 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:88px;left:110px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="f4 white queen"><img alt="f4 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:110px;left:154px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="h3 white queen"><img alt="h3 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:132px;left:88px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="e2 white queen"><img alt="e2 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:154px;left:0px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="a1 white queen"><img alt="a1 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
</div>
</td>
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
</tr>
<tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
</tbody></table>
<div class="thumbcaption">Solution 3</div>
</div>
</div>
</td>
<td style="text-align: left; vertical-align: top;">
<div class="thumb tright" style="clear:right;text-align:center;max-width:222px">
<div style="line-height:130%"></div>
<div class="thumbinner" style="width:214px">
<table cellpadding="0" cellspacing="0" style="background:white;font-size:88%;border:1px #b0b0b0 solid;padding:0;margin:auto">
<tbody><tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
<td colspan="8" rowspan="8" style="padding:0;vertical-align:inherit">
<div class="chess-board" style="position:relative"><img alt="Chessboard480.svg" src="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/176px-Chessboard480.svg.png" width="176" height="176" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/264px-Chessboard480.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Chessboard480.svg/352px-Chessboard480.svg.png 2x" data-file-width="480" data-file-height="480">
<div style="position:absolute;z-index:3;top:0px;left:66px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="d8 white queen"><img alt="d8 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:22px;left:110px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="f7 white queen"><img alt="f7 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:44px;left:154px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="h6 white queen"><img alt="h6 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:66px;left:44px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="c5 white queen"><img alt="c5 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:88px;left:0px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="a4 white queen"><img alt="a4 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:110px;left:132px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="g3 white queen"><img alt="g3 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:132px;left:88px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="e2 white queen"><img alt="e2 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
<div style="position:absolute;z-index:3;top:154px;left:22px;width:22px;height:22px"><a href="/wiki/File:Chess_qlt45.svg" class="image" title="b1 white queen"><img alt="b1 white queen" src="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/22px-Chess_qlt45.svg.png" width="22" height="22" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/33px-Chess_qlt45.svg.png 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/1/15/Chess_qlt45.svg/44px-Chess_qlt45.svg.png 2x" data-file-width="45" data-file-height="45"></a></div>
</div>
</td>
<td style="padding:0;vertical-align:inherit;width:18px;height:22px">8</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
<td style="padding:0;vertical-align:inherit;height:22px">7</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
<td style="padding:0;vertical-align:inherit;height:22px">6</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
<td style="padding:0;vertical-align:inherit;height:22px">5</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
<td style="padding:0;vertical-align:inherit;height:22px">4</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
<td style="padding:0;vertical-align:inherit;height:22px">3</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
<td style="padding:0;vertical-align:inherit;height:22px">2</td>
</tr>
<tr style="vertical-align:middle">
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
<td style="padding:0;vertical-align:inherit;height:22px">1</td>
</tr>
<tr style="vertical-align:middle">
<td style="vertical-align:inherit;padding:0"></td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">a</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">b</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">c</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">d</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">e</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">f</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">g</td>
<td style="padding:0;vartical-align:inherit;height:18px;width:22px">h</td>
<td style="vertical-align:inherit;padding:0"></td>
</tr>
</tbody></table>
<div class="thumbcaption">Solution 4</div>
</div>
</div>
</td>
</tr>
</tbody></table>
</div>
