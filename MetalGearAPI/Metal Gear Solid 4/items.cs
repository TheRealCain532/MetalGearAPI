using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiLib;

namespace MetalGearAPI
{
	public class Item_t
	{
		private uint Pointer;

		public string Name => new MCAPI().Extension.ReadString(new MCAPI().Extension.ReadUInt32(Pointer));

		public short type => new MCAPI().Extension.ReadInt16(Pointer + 4);

		private short unk0 => new MCAPI().Extension.ReadInt16(Pointer + 6);

		private short unk1 => new MCAPI().Extension.ReadInt16(Pointer + 8);

		public short Index => new MCAPI().Extension.ReadInt16(Pointer + 10);

		public short Current
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 12);
			set => new MCAPI().Extension.WriteInt16(Pointer + 12, value);
		}

		public short Max
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 14);
			set => new MCAPI().Extension.WriteInt16(Pointer + 14, value);
		}

		public Item_t(uint Base)
		{
			Pointer = Base;
		}
	}

	public class Item
	{
		public Item_t RATION;

		public Item_t NOODLES;

		public Item_t REGAIN;

		public Item_t PENTAZEMIN;

		public Item_t COMPRESS;

		public Item_t SOLIDEYE;

		public Item_t MGMkII;

		public Item_t CAMERA;

		public Item_t CBOX;

		public Item_t DRUMCAN;

		public Item_t iPod;

		public Item_t SIGNALINT;

		public Item_t CIGS;

		public Item_t Muna;

		public Item_t BANDANA;

		public Item_t STEALTH;

		public Item_t SYRINGE;

		public Item_t SPLUG;

		public Item_t BINO;

		public Item_t SSPLUG;

		public Item_t FACECAMO;

		public Item_t ENVG;

		public Item_t KEROTAN;

		public Item_t GA_KO;

		public Item_t OCTOCAMO;

		public Item_t DISGUISEME;

		public Item_t DISGUISESA;

		public Item_t DISGUISEEE;

		public Item_t ALTAIR;

		public Item_t SUIT;

		public Item_t FACECAMO_i;

		public Item_t YOUNG;

		public Item_t SBEAUTY;

		public Item_t LBEAUTY;

		public Item_t RBEAUTY;

		public Item_t CBEAUTY;

		public Item_t YOUNGwB;

		public Item_t OTACON;

		public Item_t CAMPBELL;

		public Item_t BIGBOSS;

		public Item_t DREBIN;

		public Item_t MGS1;

		public Item_t RAIDENA;

		public Item_t RAIDENB;

		public Item_t KHAKI;

		public Item_t OLIVEDRAB;

		public Item_t BLACK;

		public Item_t GREY;

		public Item_t NAVYBLUE;

		public Item_t GREEN;

		public Item_t BLUE;

		public Item_t RED;

		public Item_t ORANGE;

		public Item_t TAN;

		public Item_t FIGURE0;

		public Item_t FIGURE1;

		public Item_t FIGURE2;

		public Item_t FIGURE3;

		public Item_t FIGURE4;

		public Item_t BATTERY;

		public Item_t iPod_MUSIC0;

		public Item_t iPod_MUSIC1;

		public Item_t iPod_MUSIC2;

		public Item_t iPod_MUSIC3;

		public Item_t iPod_MUSIC4;

		public Item_t iPod_MUSIC5;

		public Item_t iPod_MUSIC6;

		public Item_t iPod_MUSIC7;

		public Item_t iPod_MUSIC8;

		public Item_t iPod_MUSIC9;

		public Item_t iPod_MUSIC10;

		public Item_t iPod_MUSIC11;

		public Item_t iPod_MUSIC12;

		public Item_t iPod_MUSIC13;

		public Item_t iPod_MUSIC14;

		public Item_t iPod_MUSIC15;

		public Item_t iPod_MUSIC16;

		public Item_t iPod_MUSIC17;

		public Item_t iPod_MUSIC18;

		public Item_t iPod_MUSIC19;

		public Item_t iPod_MUSIC20;

		public Item_t iPod_MUSIC21;

		public Item_t iPod_MUSIC22;

		public Item_t iPod_MUSIC23;

		public Item_t iPod_MUSIC24;

		public Item_t iPod_MUSIC25;

		public Item_t iPod_MUSIC26;

		public Item_t iPod_MUSIC27;

		public Item_t iPod_MUSIC28;

		public Item_t iPod_MUSIC29;

		public Item_t iPod_MUSIC30;

		public Item_t iPod_MUSIC31;

		public Item_t iPod_MUSIC32;

		public Item_t iPod_MUSIC33;

		public Item_t iPod_MUSIC34;

		public Item_t iPod_MUSIC35;

		public Item_t iPod_MUSIC36;

		public Item_t iPod_MUSIC37;

		public Item()
		{
			RATION = new Item_t(5821212u);
			NOODLES = new Item_t(5821260u);
			REGAIN = new Item_t(5821308u);
			PENTAZEMIN = new Item_t(5821356u);
			COMPRESS = new Item_t(5821404u);
			SOLIDEYE = new Item_t(5821452u);
			MGMkII = new Item_t(5821500u);
			CAMERA = new Item_t(5821548u);
			CBOX = new Item_t(5821596u);
			DRUMCAN = new Item_t(5821644u);
			iPod = new Item_t(5821692u);
			SIGNALINT = new Item_t(5821740u);
			CIGS = new Item_t(5821788u);
			Muna = new Item_t(5821836u);
			BANDANA = new Item_t(5821884u);
			STEALTH = new Item_t(5821932u);
			SYRINGE = new Item_t(5821980u);
			SPLUG = new Item_t(5822028u);
			BINO = new Item_t(5822076u);
			SSPLUG = new Item_t(5822124u);
			FACECAMO_i = new Item_t(5822172u);
			ENVG = new Item_t(5822220u);
			KEROTAN = new Item_t(5822268u);
			GA_KO = new Item_t(5822316u);
			OCTOCAMO = new Item_t(5822364u);
			DISGUISEME = new Item_t(5822412u);
			DISGUISESA = new Item_t(5822460u);
			DISGUISEEE = new Item_t(5822508u);
			ALTAIR = new Item_t(5822556u);
			SUIT = new Item_t(5822604u);
			FACECAMO = new Item_t(5822652u);
			YOUNG = new Item_t(5822700u);
			SBEAUTY = new Item_t(5822748u);
			LBEAUTY = new Item_t(5822796u);
			RBEAUTY = new Item_t(5822844u);
			CBEAUTY = new Item_t(5822892u);
			YOUNGwB = new Item_t(5822940u);
			OTACON = new Item_t(5822988u);
			CAMPBELL = new Item_t(5823036u);
			BIGBOSS = new Item_t(5823084u);
			DREBIN = new Item_t(5823132u);
			MGS1 = new Item_t(5823180u);
			RAIDENA = new Item_t(5823228u);
			RAIDENB = new Item_t(5823276u);
			KHAKI = new Item_t(5823324u);
			OLIVEDRAB = new Item_t(5823372u);
			BLACK = new Item_t(5823420u);
			GREY = new Item_t(5823468u);
			NAVYBLUE = new Item_t(5823516u);
			GREEN = new Item_t(5823564u);
			BLUE = new Item_t(5823612u);
			RED = new Item_t(5823660u);
			ORANGE = new Item_t(5823708u);
			TAN = new Item_t(5823756u);
			FIGURE0 = new Item_t(5823804u);
			FIGURE1 = new Item_t(5823852u);
			FIGURE2 = new Item_t(5823900u);
			FIGURE3 = new Item_t(5823948u);
			FIGURE4 = new Item_t(5823996u);
			BATTERY = new Item_t(5824044u);
			iPod_MUSIC0 = new Item_t(5824092u);
			iPod_MUSIC1 = new Item_t(5824140u);
			iPod_MUSIC2 = new Item_t(5824188u);
			iPod_MUSIC3 = new Item_t(5824236u);
			iPod_MUSIC4 = new Item_t(5824284u);
			iPod_MUSIC5 = new Item_t(5824332u);
			iPod_MUSIC6 = new Item_t(5824380u);
			iPod_MUSIC7 = new Item_t(5824428u);
			iPod_MUSIC8 = new Item_t(5824476u);
			iPod_MUSIC9 = new Item_t(5824524u);
			iPod_MUSIC10 = new Item_t(5824572u);
			iPod_MUSIC11 = new Item_t(5824620u);
			iPod_MUSIC12 = new Item_t(5824668u);
			iPod_MUSIC13 = new Item_t(5824716u);
			iPod_MUSIC14 = new Item_t(5824764u);
			iPod_MUSIC15 = new Item_t(5824812u);
			iPod_MUSIC16 = new Item_t(5824860u);
			iPod_MUSIC17 = new Item_t(5824908u);
			iPod_MUSIC18 = new Item_t(5824956u);
			iPod_MUSIC19 = new Item_t(5825004u);
			iPod_MUSIC20 = new Item_t(5825052u);
			iPod_MUSIC21 = new Item_t(5825100u);
			iPod_MUSIC22 = new Item_t(5825148u);
			iPod_MUSIC23 = new Item_t(5825196u);
			iPod_MUSIC24 = new Item_t(5825244u);
			iPod_MUSIC25 = new Item_t(5825292u);
			iPod_MUSIC26 = new Item_t(5825340u);
			iPod_MUSIC27 = new Item_t(5825388u);
			iPod_MUSIC28 = new Item_t(5825436u);
			iPod_MUSIC29 = new Item_t(5825484u);
			iPod_MUSIC30 = new Item_t(5825532u);
			iPod_MUSIC31 = new Item_t(5825580u);
			iPod_MUSIC32 = new Item_t(5825628u);
			iPod_MUSIC33 = new Item_t(5825676u);
			iPod_MUSIC34 = new Item_t(5825724u);
			iPod_MUSIC35 = new Item_t(5825772u);
			iPod_MUSIC36 = new Item_t(5825820u);
			iPod_MUSIC37 = new Item_t(5825868u);
		}

		public void UnlockItems()
		{
			Item_t[] array = new Item_t[]
			{
				RATION, NOODLES, REGAIN, PENTAZEMIN, COMPRESS, SOLIDEYE, MGMkII, CAMERA, CBOX, DRUMCAN,
				iPod, SIGNALINT, CIGS, Muna, BANDANA, STEALTH, SYRINGE, SPLUG, BINO, SSPLUG,
				FACECAMO, ENVG, KEROTAN, GA_KO, OCTOCAMO, DISGUISEME, DISGUISESA, DISGUISEEE, ALTAIR, SUIT,
				FACECAMO_i, YOUNG, SBEAUTY, LBEAUTY, RBEAUTY, CBEAUTY, YOUNGwB, OTACON, CAMPBELL, BIGBOSS,
				DREBIN, MGS1, RAIDENA, RAIDENB, KHAKI, OLIVEDRAB, BLACK, GREY, NAVYBLUE, GREEN,
				BLUE, RED, ORANGE, TAN, FIGURE0, FIGURE1, FIGURE2, FIGURE3, FIGURE4, BATTERY,
				iPod_MUSIC0, iPod_MUSIC1, iPod_MUSIC2, iPod_MUSIC3, iPod_MUSIC4, iPod_MUSIC5, iPod_MUSIC6, iPod_MUSIC7, iPod_MUSIC8, iPod_MUSIC9,
				iPod_MUSIC10, iPod_MUSIC11, iPod_MUSIC12, iPod_MUSIC13, iPod_MUSIC14, iPod_MUSIC15, iPod_MUSIC16, iPod_MUSIC17, iPod_MUSIC18, iPod_MUSIC19,
				iPod_MUSIC20, iPod_MUSIC21, iPod_MUSIC22, iPod_MUSIC23, iPod_MUSIC24, iPod_MUSIC25, iPod_MUSIC26, iPod_MUSIC27, iPod_MUSIC28, iPod_MUSIC29,
				iPod_MUSIC30, iPod_MUSIC31, iPod_MUSIC32, iPod_MUSIC33, iPod_MUSIC34, iPod_MUSIC35, iPod_MUSIC36, iPod_MUSIC37
			};
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Current = 532;
			}
		}
	}

}
