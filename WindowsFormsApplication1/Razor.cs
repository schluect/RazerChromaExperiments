﻿using Corale.Colore.Razer.Keyboard.Effects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Razor
    {
        public void ChangeColor(string value)
        {
            try
            {
                Color color = (Color)new ColorConverter().ConvertFromString(value);
                // Corale.Colore.Core.Keyboard.Instance.Clear();
                Corale.Colore.Core.Keyboard.Instance.Set(new Corale.Colore.Core.Color(color.R, color.G, color.B));
            }catch(Exception ex){}            
        }
    }

    //class Keyboard
    //{
    //     //! Chroma supported products
    //    enum PRODUCTTYPE
    //    {
    //        PRODUCT_NONE = 0,
    //        PRODUCT_BLACKWIDOW_CHROMA,  // Device Id = 2EA1BB63-CA28-428D-9F06-196B88330BBB
    //        PRODUCT_INVALID
    //    }

    //    //! Event notification Window message
    //    //const UINT WM_CHROMA_EVENT = WM_APP+0x2000;
        
    //    //! Definitions of keys.
    //    enum RZKEY
    //    {
    //        RZKEY_ESC = 0x0001,                 /*!< Esc */
    //        RZKEY_F1 = 0x0003,                  /*!< F1 */
    //        RZKEY_F2 = 0x0004,                  /*!< F2 */
    //        RZKEY_F3 = 0x0005,                  /*!< F3 */
    //        RZKEY_F4 = 0x0006,                  /*!< F4 */
    //        RZKEY_F5 = 0x0007,                  /*!< F5 */
    //        RZKEY_F6 = 0x0008,                  /*!< F6 */
    //        RZKEY_F7 = 0x0009,                  /*!< F7 */
    //        RZKEY_F8 = 0x000A,                  /*!< F8 */
    //        RZKEY_F9 = 0x000B,                  /*!< F9 */
    //        RZKEY_F10 = 0x000C,                 /*!< F10 */
    //        RZKEY_F11 = 0x000D,                 /*!< F11 */
    //        RZKEY_F12 = 0x000E,                 /*!< F12 */
    //        RZKEY_1 = 0x0102,                   /*!< 1 */
    //        RZKEY_2 = 0x0103,                   /*!< 2 */
    //        RZKEY_3 = 0x0104,                   /*!< 3 */
    //        RZKEY_4 = 0x0105,                   /*!< 4 */
    //        RZKEY_5 = 0x0106,                   /*!< 5 */
    //        RZKEY_6 = 0x0107,                   /*!< 6 */
    //        RZKEY_7 = 0x0108,                   /*!< 7 */
    //        RZKEY_8 = 0x0109,                   /*!< 8 */
    //        RZKEY_9 = 0x010A,                   /*!< 9 */
    //        RZKEY_0 = 0x010B,                   /*!< 0 */
    //        RZKEY_A = 0x0302,                   /*!< A */
    //        RZKEY_B = 0x0407,                   /*!< B */
    //        RZKEY_C = 0x0405,                   /*!< C */
    //        RZKEY_D = 0x0304,                   /*!< D */
    //        RZKEY_E = 0x0204,                   /*!< E */
    //        RZKEY_F = 0x0305,                   /*!< F */
    //        RZKEY_G = 0x0306,                   /*!< G */
    //        RZKEY_H = 0x0307,                   /*!< H */
    //        RZKEY_I = 0x0209,                   /*!< I */
    //        RZKEY_J = 0x0308,                   /*!< J */
    //        RZKEY_K = 0x0309,                   /*!< K */
    //        RZKEY_L = 0x030A,                   /*!< L */
    //        RZKEY_M = 0x0409,                   /*!< M */
    //        RZKEY_N = 0x0408,                   /*!< N */
    //        RZKEY_O = 0x020A,                   /*!< O */
    //        RZKEY_P = 0x020B,                   /*!< P */
    //        RZKEY_Q = 0x0202,                   /*!< Q */
    //        RZKEY_R = 0x0205,                   /*!< R */
    //        RZKEY_S = 0x0303,                   /*!< S */
    //        RZKEY_T = 0x0206,                   /*!< T */
    //        RZKEY_U = 0x0208,                   /*!< U */
    //        RZKEY_V = 0x0406,                   /*!< V */
    //        RZKEY_W = 0x0203,                   /*!< W */
    //        RZKEY_X = 0x0404,                   /*!< X */
    //        RZKEY_Y = 0x0207,                   /*!< Y */
    //        RZKEY_Z = 0x0403,                   /*!< Z */
    //        RZKEY_NUMLOCK = 0x0112,             /*!< Numlock */
    //        RZKEY_NUMPAD0 = 0x0513,             /*!< Numpad 0 */
    //        RZKEY_NUMPAD1 = 0x0412,             /*!< Numpad 1 */
    //        RZKEY_NUMPAD2 = 0x0413,             /*!< Numpad 2 */
    //        RZKEY_NUMPAD3 = 0x0414,             /*!< Numpad 3 */
    //        RZKEY_NUMPAD4 = 0x0312,             /*!< Numpad 4 */
    //        RZKEY_NUMPAD5 = 0x0313,             /*!< Numpad 5 */
    //        RZKEY_NUMPAD6 = 0x0314,             /*!< Numpad 6 */
    //        RZKEY_NUMPAD7 = 0x0212,             /*!< Numpad 7 */
    //        RZKEY_NUMPAD8 = 0x0213,             /*!< Numpad 8 */
    //        RZKEY_NUMPAD9 = 0x0214,             /*!< Numpad 9*/
    //        RZKEY_NUMPAD_DIVIDE = 0x0113,       /*!< Divide */
    //        RZKEY_NUMPAD_MULTIPLY = 0x0114,     /*!< Multiply */
    //        RZKEY_NUMPAD_SUBTRACT = 0x0115,     /*!< Subtract */
    //        RZKEY_NUMPAD_ADD = 0x0215,          /*!< Add */
    //        RZKEY_NUMPAD_ENTER = 0x0415,        /*!< Enter */
    //        RZKEY_NUMPAD_DECIMAL = 0x0514,      /*!< Decimal */
    //        RZKEY_PRINTSCREEN = 0x000F,         /*!< Print Screen */
    //        RZKEY_SCROLL = 0x0010,              /*!< Scroll Lock */
    //        RZKEY_PAUSE = 0x0011,               /*!< Pause */
    //        RZKEY_INSERT = 0x010F,              /*!< Insert */
    //        RZKEY_HOME = 0x0110,                /*!< Home */
    //        RZKEY_PAGEUP = 0x0111,              /*!< Page Up */
    //        RZKEY_DELETE = 0x020f,              /*!< Delete */
    //        RZKEY_END = 0x0210,                 /*!< End */
    //        RZKEY_PAGEDOWN = 0x0211,            /*!< Page Down */
    //        RZKEY_UP = 0x0410,                  /*!< Up */
    //        RZKEY_LEFT = 0x050F,                /*!< Left */
    //        RZKEY_DOWN = 0x0510,                /*!< Down */
    //        RZKEY_RIGHT = 0x0511,               /*!< Right */
    //        RZKEY_TAB = 0x0201,                 /*!< Tab */
    //        RZKEY_CAPSLOCK = 0x0301,            /*!< Caps Lock*/
    //        RZKEY_BACKSPACE = 0x010E,           /*!<  Backspace */
    //        RZKEY_ENTER = 0x030E,               /*!< Enter */
    //        RZKEY_LCTRL = 0x0501,               /*!< Left Control*/
    //        RZKEY_LWIN = 0x0502,                /*!< Left Window */
    //        RZKEY_LALT = 0x0503,                /*!< Left Alt */
    //        RZKEY_SPACE = 0x0507,               /*!< Spacebar */
    //        RZKEY_RALT = 0x050B,                /*!< Right Alt */
    //        RZKEY_FN = 0x050C,                  /*!< 'Fn' function key. */
    //        RZKEY_RMENU = 0x050D,               /*!< Right Menu */
    //        RZKEY_RCTRL = 0x050E,               /*!< Right Control */
    //        RZKEY_LSHIFT = 0x0401,              /*!< Left Shift */
    //        RZKEY_RSHIFT = 0x040E,              /*!< Right Shift */
    //        RZKEY_MACRO1 = 0x0100,              /*!< Macro Key 1*/
    //        RZKEY_MACRO2 = 0x0200,              /*!< Macro Key 2*/
    //        RZKEY_MACRO3 = 0x0300,              /*!< Macro Key 3 */
    //        RZKEY_MACRO4 = 0x0400,              /*!< Macro Key 4*/
    //        RZKEY_MACRO5 = 0x0500,              /*!< Macro Key 5 */
    //        RZKEY_OEM_1 = 0x0101,               /*!< ~  tilde. 半角/全角 */
    //        RZKEY_OEM_2 = 0x010C,               /*!< -  minus. */
    //        RZKEY_OEM_3 = 0x010D,               /*!< =  equal. */
    //        RZKEY_OEM_4 = 0x020C,               /*!< [  left sqaure bracket. */
    //        RZKEY_OEM_5 = 0x020D,               /*!< ]  right square bracket. */
    //        RZKEY_OEM_6 = 0x020E,               /*!< \  forward slash. */
    //        RZKEY_OEM_7 = 0x030B,               /*!< ;  semi-colon. */
    //        RZKEY_OEM_8 = 0x030C,               /*!< '  apostrophe. */
    //        RZKEY_OEM_9 = 0x040A,               /*!< ,  comma. */
    //        RZKEY_OEM_10 = 0x040B,              /*!< .  period. */
    //        RZKEY_OEM_11 = 0x040C,              /*!< /  backslash. */
    //        RZKEY_EUR_1 = 0x030D,               /*!< # */
    //        RZKEY_EUR_2 = 0x0402,               /*!< \ */
    //        RZKEY_JPN_1 = 0x0015,               /*!< ¥ */
    //        RZKEY_JPN_2 = 0x040D,               /*!< / */
    //        RZKEY_JPN_3 = 0x0504,               /*!< 無変換 */
    //        RZKEY_JPN_4 = 0x0509,               /*!< 変換 */
    //        RZKEY_JPN_5 = 0x050A,               /*!< ひらがな/カタカナ */
    //        RZKEY_KOR_1 = 0x0015,               /*!< | */
    //        RZKEY_KOR_2 = 0x030D,
    //        RZKEY_KOR_3 = 0x0402,
    //        RZKEY_KOR_4 = 0x040D,
    //        RZKEY_KOR_5 = 0x0504,               /*!< 한자 */
    //        RZKEY_KOR_6 = 0x0509,               /*!< 한/영 */
    //        RZKEY_KOR_7 = 0x050A,
    //        RZKEY_INVALID = 0xFFFF              /*!< Invalid keys. */
    //    }

    //    //! Maximum number of rows in a keyboard.
    //    const int MAX_ROW = 6;

    //    //! Maximum number of columns in a keyboard.
    //    const int MAX_COLUMN = 22;

    //    //! Maximum number of keys.
    //    const int MAX_KEYS = MAX_ROW * MAX_COLUMN;

    //    //! Maximum number of custom effects.
    //    const int MAX_CUSTOM_EFFECTS = MAX_KEYS;

    //    //! Keyboard grid layout.
    //    const Color[,] RZKEY_GRID_LAYOUT = new Color[MAX_ROW, MAX_COLUMN];

    //    //! Chroma keyboard effect types
    //    enum EFFECT_TYPE
    //    {
    //        CHROMA_NONE = 0,            //!< No effect.
    //        CHROMA_WAVE,                //!< Wave effect.
    //        CHROMA_SPECTRUMCYCLING,     //!< Spectrum cycling effect.
    //        CHROMA_BREATHING,           //!< Breathing effect.
    //        CHROMA_REACTIVE,            //!< Reactive effect.
    //        CHROMA_STATIC,              //!< Static effect.
    //        CHROMA_INVALID              //!< Invalid effect.
    //    }

    //    // Chroma keyboard effects
    //    //! Wave effect type
    //    struct WAVE_EFFECT_TYPE
    //    {
    //        //! Direction of the wave effect.
    //        enum Direction
    //        {
    //            DIRECTION_NONE=0,           //!< No direction.
    //            DIRECTION_LEFT_TO_RIGHT,    //!< Left to right.
    //            DIRECTION_RIGHT_TO_LEFT,    //!< Right to left.
    //            DIRECTION_INVALID           //!< Invalid direction.
    //        }                   //!< Direction of the wave.
    //    }

    //    //! Breathing effect type
    //    struct BREATHING_EFFECT_TYPE
    //    {
    //        Color Color1;    //!< First color.
    //        Color Color2;    //!< Second color.
    //    }

    //    //! Reactive effect type
    //    struct REACTIVE_EFFECT_TYPE
    //    {
    //        Color Color;         //!< Color of the effect

    //        //! Duration of the effect.
    //        enum Duration
    //        {
    //            DURATION_NONE=0,    //!< No duration.
    //            DURATION_SHORT,     //!< Short duration.
    //            DURATION_MEDIUM,    //!< Medium duration.
    //            DURATION_LONG,      //!< Long duration.
    //            DURATION_INVALID    //!< Invalid duraiont
    //        }             //!< The time taken for the effect to fade away.
    //    }

    //    //! Static effect type
    //    struct STATIC_EFFECT_TYPE
    //    {
    //        Color Color;     //!< Color of the effect
    //    }

    //    //! Custom effect using RZKEY type
    //    struct CUSTOM_EFFECT_TYPE
    //    {
    //        RZKEY Key;          //!< The key to apply customized effect.
    //        Color Color;     //!< Color of the key.
    //    }

    //    //! Custom effect using a grid type
    //    struct CUSTOM_GRID_EFFECT_TYPE
    //    {
    //        Color[,] Key; //!< Grid layout. 6 rows by 22 columns.
    //    }
    //}
}
