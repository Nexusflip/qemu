# CS_ARCH_ARM, CS_MODE_THUMB, None
0xfb,0xff,0x20,0x04 = vrecpe.u32 d16, d16
0xfb,0xff,0x60,0x04 = vrecpe.u32 q8, q8
0xfb,0xff,0x20,0x05 = vrecpe.f32 d16, d16
0xfb,0xff,0x60,0x05 = vrecpe.f32 q8, q8
0x40,0xef,0xb1,0x0f = vrecps.f32 d16, d16, d17
0x40,0xef,0xf2,0x0f = vrecps.f32 q8, q8, q9
0xfb,0xff,0xa0,0x04 = vrsqrte.u32 d16, d16
0xfb,0xff,0xe0,0x04 = vrsqrte.u32 q8, q8
0xfb,0xff,0xa0,0x05 = vrsqrte.f32 d16, d16
0xfb,0xff,0xe0,0x05 = vrsqrte.f32 q8, q8
0x60,0xef,0xb1,0x0f = vrsqrts.f32 d16, d16, d17
0x60,0xef,0xf2,0x0f = vrsqrts.f32 q8, q8, q9
