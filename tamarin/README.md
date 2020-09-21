# Tamarin

## Problem

[Tamarin.7z](./Tamarin.7z)

## Files

* [Tamarin.7z](./Tamarin.7z) - Provided 7z file
  - [Tamarin.apk](./Tamarin.apk) - Challenge APK

## Solution

### Emulation

`7z x Tamarin.7z` extracts the only provided file: `Tamarin.apk`. Usually importing an APK into Android Studio and running it in an emulator is trivial, but in this case it was not. Attempting to run it resulted in this error:

![abi.png](images/abi.png)



Success! Solution was to decompile with `apktool` then `mono_unbundle` then reverse the C#

Turns out to be some normalizing of numbers. Since we know what the final number should be,
we can reverse it:

Function(coefficients, x, pos) = (coefficients[pos] * x^pos) + (coefficients[pos-1] * x^pos-1) + ...

We know what the result should be, so the flag integer is:

final_result - Function(coeffiecents, x, pos).

Requires that function() exit when pos is 0 instead of -1.

Woo!


Flag: `TWCTF{Xm4r1n_15_4bl3_70_6en3r4t3_N471v3_C0d3_w17h_VS_3n73rpr153_bu7_17_c0n741n5_D07_N3t_B1n4ry}`

![flag.png](images/flag.png)
