# TokyoWesterns CTF 2020

## Challenges I Worked On

### urlcheck v1

Failure :( solution was to put first octet in octal

## Tamarin

Success! Solution was to decompile with `apktool` then `mono_unbundle` then reverse the C#

Turns out to be some normalizing of numbers. Since we know what the final number should be,
we can reverse it:

Function(coefficients, x, pos) = (coefficients[pos] * x^pos) + (coefficients[pos-1] * x^pos-1) + ...

We know what the result should be, so the flag integer is:

final_result - Function(coeffiecents, x, pos). 

Requires that function() exit when pos is 0 instead of -1. 

Woo!


Flag: `TWCTF{Xm4r1n_15_4bl3_70_6en3r4t3_N471v3_C0d3_w17h_VS_3n73rpr153_bu7_17_c0n741n5_D07_N3t_B1n4ry}`
