# Uint8ArrayCheck
.Net 6 preview 7 Blazor byte[] serialization bug test project

This project was created to demonstrate unexpected behavior in the .Net 6 preview 7 serialization/deserialization of Blazor byte[] -> Javascript Uint8Array. 



Uint8Array created by byte[] deserialization in javascript has incorrect buffer property byteLength #35597
https://github.com/dotnet/aspnetcore/issues/35597

When passing byte arrays from Blazor to Javascript the resulting Uint8Array's buffer property (an ArrayBuffer) has an ~~incorrect~~ unexpected, and MUCH larger, byte length. The Uint8Array has a correct byteLength.

A Blazor byte[2], byte[10], byte[100], or even byte[1000] results in a Uint8Array.buffer.byteLength == 62128128.

A byte[62128128] results in Uint8Array.buffer.byteLength == 118358016.



The issue has been fixed in .Net 6 RC1
