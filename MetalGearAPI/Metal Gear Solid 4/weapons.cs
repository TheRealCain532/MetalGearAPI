using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiLib;

namespace MetalGearAPI
{
	//Inf Ammo flag has 3 levels
	//0 = off
	//1 = inf ammo
	//2 = no reload
	//3 = inf ammo & no reload


	public class Weapon_t
	{

		public class GM_IV_MENU
		{
			public long
				name,
				sv_name,
				group,
				icon,
				icon_tex;
			public GM_IV_MENU(uint Pointer)
			{

			}
		}
		public class GM_IV_WEAPON
		{
			private uint BasePointer;
			GM_IV_MENU GM_IV_MENU; //00 - 14
			public long
				type,
				p_num,
				p_max;
			public short
				load,
				load_max;
			public long
				file_ofst,
				rsc_ofst;
			public short
				flag,
				n_attach;
			public long
				attach,
				custom,
				pl_plugin,
				data;
			public GM_IV_WEAPON() { }
		}


		private uint Pointer;

		public string Name => new MCAPI().Extension.ReadString(new MCAPI().Extension.ReadUInt32(Pointer));

		public short CQC
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 4);
			set => new MCAPI().Extension.WriteInt16(Pointer + 4, value);
		}

		public Type WeaponType
		{
			get => (Type)new MCAPI().Extension.ReadInt16(Pointer + 6);
			set => new MCAPI().Extension.WriteInt16(Pointer + 6, (short)value);
		}

		private short unk1 => new MCAPI().Extension.ReadInt16(Pointer + 8);

		public short Weight
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 10);
			set => new MCAPI().Extension.WriteInt16(Pointer + 10, value);

		}

		public short CurrentAmmo => new MCAPI().Extension.ReadInt16(new MCAPI().Extension.ReadUInt32(Pointer + 12));

		public short MaxAmmo => new MCAPI().Extension.ReadInt16(new MCAPI().Extension.ReadUInt32(Pointer + 16));

		public short AmmoType => new MCAPI().Extension.ReadInt16(Pointer + 20);

		public bool Unlocked
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 22) == 2;
			set => new MCAPI().Extension.WriteInt16(Pointer + 22, (short)(value ? 2 : 0));
		}

		private short unk5 => new MCAPI().Extension.ReadInt16(Pointer + 24);

		public Attachments Attachment
		{
			get => (Attachments)new MCAPI().Extension.ReadInt16(Pointer + 26);
			set => new MCAPI().Extension.WriteInt16(Pointer + 26, (short)((short)Attachment + value));
		}

		public short Magazine
		{
			get => new MCAPI().Extension.ReadInt16(Pointer + 28);
			set => new MCAPI().Extension.WriteInt16(Pointer + 28, value);
		}

		public short MagSize => new MCAPI().Extension.ReadInt16(Pointer + 30);

		private short unk9 => new MCAPI().Extension.ReadInt16(Pointer + 32);

		public short WeaponID => new MCAPI().Extension.ReadInt16(Pointer + 34);

		private short unk11 => new MCAPI().Extension.ReadInt16(Pointer + 36);

		private short unk12 => new MCAPI().Extension.ReadInt16(Pointer + 38);

		private short unk13 => new MCAPI().Extension.ReadInt16(Pointer + 40);

		private short unk14 => new MCAPI().Extension.ReadInt16(Pointer + 42);

		private short unk15 => new MCAPI().Extension.ReadInt16(Pointer + 44);

		public iAmmo_f InfAmmoFlag
		{
			get => (iAmmo_f)new MCAPI().Extension.ReadInt16(Pointer + 47);
			set => new MCAPI().Extension.WriteInt16(Pointer + 46, (short)value);
		}

		private short unk17 => new MCAPI().Extension.ReadInt16(Pointer + 48);

		private short unk18 => new MCAPI().Extension.ReadInt16(Pointer + 50);
		public uint PointerAddress => Pointer;


		public Weapon_t(uint Base)
		{
			Pointer = Base;
		}
	}

	public class Weapon
	{
		public class Ammo_t
		{
			private uint Pointer;

			public string Name => new MCAPI().Extension.ReadString(new MCAPI().Extension.ReadUInt32(Pointer));

			public short Amount
			{
				get
				{
					return new MCAPI().Extension.ReadInt16(Pointer + 8);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 8, value);
				}
			}

			public short Max
			{
				get
				{
					return new MCAPI().Extension.ReadInt16(Pointer + 10);
				}
				set
				{
					new MCAPI().Extension.WriteInt16(Pointer + 10, value);
				}
			}

			public Ammo_t(uint Base)
			{
				Pointer = Base;
			}
		}

		public class Ammo
		{
			public Ammo_t NONE;

			public Ammo_t ANEST22;

			public Ammo_t SCREAM22;

			public Ammo_t LAUGH22;

			public Ammo_t RAGE22;

			public Ammo_t CRY22;

			public Ammo_t ANEST762mm;

			public Ammo_t SCREAM762mm;

			public Ammo_t LAUGH762mm;

			public Ammo_t RAGE762mm;

			public Ammo_t CRY762mm;

			public Ammo_t _9x23mm;

			public Ammo_t _45ACP;

			public Ammo_t _4570;

			public Ammo_t _50AE;

			public Ammo_t _50BMR;

			public Ammo_t _46x30mm;

			public Ammo_t _545x39mm;

			public Ammo_t _556x45mm;

			public Ammo_t _57x28mm;

			public Ammo_t _762x42mm;

			public Ammo_t _762x51mm;

			public Ammo_t _762x54R;

			public Ammo_t _9x18mm;

			public Ammo_t _9x19mm;

			public Ammo_t _9x39mm;

			public Ammo_t _762x67mm;

			public Ammo_t LEADBALL;

			public Ammo_t _12GA00BUCK;

			public Ammo_t _12GASLUG;

			public Ammo_t _12GAVRING;

			public Ammo_t _40mmGGP30;

			public Ammo_t _40mmGRENADE;

			public Ammo_t _40mmWPG;

			public Ammo_t _40mmSTUNG;

			public Ammo_t _40mmSMOKEG;

			public Ammo_t _25mmABG;

			public Ammo_t FIM_92A;

			public Ammo_t JAVELIN;

			public Ammo_t RPG_7;

			public Ammo_t M72A3;

			public Ammo_t GRENADE;

			public Ammo_t WPG;

			public Ammo_t STUNG;

			public Ammo_t CHAFFG;

			public Ammo_t SMOKEG;

			public Ammo_t SMOKEGR;

			public Ammo_t SMOKEGG;

			public Ammo_t SMOKEGY;

			public Ammo_t SMOKEGB;

			public Ammo_t PETROBOMB;

			public Ammo_t MAGAZINE;

			public Ammo_t EMPGRENADE;

			public Ammo_t CLAYMORE;

			public Ammo_t SGMINE;

			public Ammo_t C4;

			public Ammo_t SGSATCHEL;

			public Ammo_t SOPDESTAB;

			public Ammo_t PLAYBOY;

			public Ammo_t EMOTIONMAG;

			public Ammo_t RAILGUNAMMO;

			public Ammo_t SUPOp;

			public Ammo_t SUPMk23;

			public Ammo_t SUP1911;

			public Ammo_t SUPM10;

			public Ammo_t SUPP90;

			public Ammo_t SUPM4;

			public Ammo()
			{
				NONE = new Ammo_t(5815408u);
				ANEST22 = new Ammo_t(5815420u);
				SCREAM22 = new Ammo_t(5815432u);
				LAUGH22 = new Ammo_t(5815444u);
				RAGE22 = new Ammo_t(5815456u);
				CRY22 = new Ammo_t(5815468u);
				ANEST762mm = new Ammo_t(5815480u);
				SCREAM762mm = new Ammo_t(5815492u);
				LAUGH762mm = new Ammo_t(5815504u);
				RAGE762mm = new Ammo_t(5815516u);
				CRY762mm = new Ammo_t(5815528u);
				_9x23mm = new Ammo_t(5815540u);
				_45ACP = new Ammo_t(5815552u);
				_4570 = new Ammo_t(5815564u);
				_50AE = new Ammo_t(5815576u);
				_50BMR = new Ammo_t(5815588u);
				_46x30mm = new Ammo_t(5815600u);
				_545x39mm = new Ammo_t(5815612u);
				_556x45mm = new Ammo_t(5815624u);
				_57x28mm = new Ammo_t(5815636u);
				_762x42mm = new Ammo_t(5815648u);
				_762x51mm = new Ammo_t(5815660u);
				_762x54R = new Ammo_t(5815672u);
				_9x18mm = new Ammo_t(5815684u);
				_9x19mm = new Ammo_t(5815696u);
				_9x39mm = new Ammo_t(5815708u);
				_762x67mm = new Ammo_t(5815720u);
				LEADBALL = new Ammo_t(5815732u);
				_12GA00BUCK = new Ammo_t(5815744u);
				_12GASLUG = new Ammo_t(5815756u);
				_12GAVRING = new Ammo_t(5815768u);
				_40mmGGP30 = new Ammo_t(5815780u);
				_40mmGRENADE = new Ammo_t(5815792u);
				_40mmWPG = new Ammo_t(5815804u);
				_40mmSTUNG = new Ammo_t(5815816u);
				_40mmSMOKEG = new Ammo_t(5815828u);
				_25mmABG = new Ammo_t(5815840u);
				FIM_92A = new Ammo_t(5815852u);
				JAVELIN = new Ammo_t(5815864u);
				RPG_7 = new Ammo_t(5815876u);
				M72A3 = new Ammo_t(5815888u);
				GRENADE = new Ammo_t(5815900u);
				WPG = new Ammo_t(5815912u);
				STUNG = new Ammo_t(5815924u);
				CHAFFG = new Ammo_t(5815936u);
				SMOKEG = new Ammo_t(5815948u);
				SMOKEGR = new Ammo_t(5815960u);
				SMOKEGG = new Ammo_t(5815972u);
				SMOKEGY = new Ammo_t(5815984u);
				SMOKEGB = new Ammo_t(5815996u);
				PETROBOMB = new Ammo_t(5816008u);
				MAGAZINE = new Ammo_t(5816020u);
				EMPGRENADE = new Ammo_t(5816032u);
				CLAYMORE = new Ammo_t(5816044u);
				SGMINE = new Ammo_t(5816056u);
				C4 = new Ammo_t(5816068u);
				SGSATCHEL = new Ammo_t(5816080u);
				SOPDESTAB = new Ammo_t(5816092u);
				PLAYBOY = new Ammo_t(5816104u);
				EMOTIONMAG = new Ammo_t(5816116u);
				RAILGUNAMMO = new Ammo_t(5816128u);
				SUPOp = new Ammo_t(5816140u);
				SUPMk23 = new Ammo_t(5816152u);
				SUP1911 = new Ammo_t(5816164u);
				SUPM10 = new Ammo_t(5816176u);
				SUPP90 = new Ammo_t(5816188u);
				SUPM4 = new Ammo_t(5816200u);
			}

			public void MaxAmmo()
			{
				Ammo_t[] array;
				array = new Ammo_t[67]
				{
					NONE, ANEST22, SCREAM22, LAUGH22, RAGE22, CRY22, ANEST762mm, SCREAM762mm, LAUGH762mm, RAGE762mm,
					CRY762mm, _9x23mm, _45ACP, _4570, _50AE, _50BMR, _46x30mm, _545x39mm, _556x45mm, _57x28mm,
					_762x42mm, _762x51mm, _762x54R, _9x18mm, _9x19mm, _9x39mm, _762x67mm, LEADBALL, _12GA00BUCK, _12GASLUG,
					_12GAVRING, _40mmGGP30, _40mmGRENADE, _40mmWPG, _40mmSTUNG, _40mmSMOKEG, _25mmABG, FIM_92A, JAVELIN, RPG_7,
					M72A3, GRENADE, WPG, STUNG, CHAFFG, SMOKEG, SMOKEGR, SMOKEGG, SMOKEGY, SMOKEGB,
					PETROBOMB, MAGAZINE, EMPGRENADE, CLAYMORE, SGMINE, C4, SGSATCHEL, SOPDESTAB, PLAYBOY, EMOTIONMAG,
					RAILGUNAMMO, SUPOp, SUPMk23, SUP1911, SUPM10, SUPP90, SUPM4
				};
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Amount = array[i].Max;
				}
			}
		}

		public Ammo Ammunition;

		public Weapon_t STUNKNIFE;

		public Weapon_t Mk2PISTOL;

		public Weapon_t OPERATOR;

		public Weapon_t Mk23;

		public Weapon_t PMM;

		public Weapon_t FIVESEVEN;

		public Weapon_t GSR;

		public Weapon_t DE;

		public Weapon_t DE_LB;

		public Weapon_t THOR4570;

		public Weapon_t _1911CUSTOM;

		public Weapon_t RACEGUN;

		public Weapon_t SOLARGUN;

		public Weapon_t PSS;

		public Weapon_t G18C;

		public Weapon_t TYPE17;

		public Weapon_t MP7;

		public Weapon_t MP5SD2;

		public Weapon_t M10;

		public Weapon_t P90;

		public Weapon_t BIZON;

		public Weapon_t PATRIOT;

		public Weapon_t Vz83;

		public Weapon_t M4CUSTOM;

		public Weapon_t AK102;

		public Weapon_t G3A3;

		public Weapon_t AN94;

		public Weapon_t FALCARBINE;

		public Weapon_t TANEGASHIMA;

		public Weapon_t Mk17;

		public Weapon_t XM8;

		public Weapon_t Mk46MOD1;

		public Weapon_t HK21E;

		public Weapon_t PKM;

		public Weapon_t M60E4;

		public Weapon_t TWINBARREL;

		public Weapon_t M870CUSTOM;

		public Weapon_t SAIGA12;

		public Weapon_t VSS;

		public Weapon_t M82A2;

		public Weapon_t DSR_1;

		public Weapon_t M14EBR;

		public Weapon_t MOSIN_NAGANT;

		public Weapon_t SVD;

		public Weapon_t RAILGUN;

		public Weapon_t MGL_140;

		public Weapon_t XM25;

		public Weapon_t FIM_92A;

		public Weapon_t JAVELIN;

		public Weapon_t RPG_7;

		public Weapon_t M72A3;

		public Weapon_t GRENADE;

		public Weapon_t WPG;

		public Weapon_t STUNG;

		public Weapon_t CHAFFG;

		public Weapon_t SMOKEG;

		public Weapon_t SMOKEG_R;

		public Weapon_t SMOKEG_G;

		public Weapon_t SMOKEG_Y;

		public Weapon_t SMOKEG_B;

		public Weapon_t PETROBOMB;

		public Weapon_t MAGAZINE;

		public Weapon_t ELOCATER;

		public Weapon_t CLAYMORE;

		public Weapon_t SGMINE;

		public Weapon_t C4;

		public Weapon_t SGSATCHEL;

		public Weapon_t SOPDESTAB;

		public Weapon_t PLAYBOY;

		public Weapon_t EMOTIONMAG;

		public Weapon_t MANTISDOLL;

		public Weapon_t SORROWDOLL;

		public Weapon_t SHIELD;

		public Weapon_t MASTERKEY;

		public Weapon_t XM320;

		public Weapon_t GP30;

		public Weapon_t SUP_Op;

		public Weapon_t SUP_Mk23;

		public Weapon_t SUP_1911;

		public Weapon_t SUP_M10;

		public Weapon_t SUP_P90;

		public Weapon_t SUP_M4;

		public Weapon_t SUP_M14;

		public Weapon_t SCOPE;

		public Weapon_t DOTSIGHT;

		public Weapon_t DSIGHT_MP7;

		public Weapon_t FLIGHT_LG;

		public Weapon_t LASERSIGHT;

		public Weapon_t FLIGHT_HG;

		public Weapon_t FOREGRIPA;

		public Weapon_t FOREGRIPB;

		public Weapon_t GATLINGGUN;

		public Weapon_t ATMISSILE;

		public Weapon_t FELASER;

		public Weapon_t NONE;

		public iAmmo_f InfiniteAmmoAll
		{
			get
			{
				return InfiniteAmmoAll;
			}
			set
			{
				Weapon_t[] array;
				array = new Weapon_t[]
				{
					STUNKNIFE, Mk2PISTOL, OPERATOR, Mk23, PMM, FIVESEVEN, GSR, DE, DE_LB, THOR4570,
					_1911CUSTOM, RACEGUN, SOLARGUN, PSS, G18C, TYPE17, MP7, MP5SD2, M10, P90,
					BIZON, PATRIOT, Vz83, M4CUSTOM, AK102, G3A3, AN94, FALCARBINE, TANEGASHIMA, Mk17,
					XM8, Mk46MOD1, HK21E, PKM, M60E4, TWINBARREL, M870CUSTOM, SAIGA12, VSS, M82A2,
					DSR_1, M14EBR, MOSIN_NAGANT, SVD, RAILGUN, MGL_140, XM25, FIM_92A, JAVELIN, RPG_7,
					M72A3, GRENADE, WPG, STUNG, CHAFFG, SMOKEG, SMOKEG_R, SMOKEG_G, SMOKEG_Y, SMOKEG_B,
					PETROBOMB, MAGAZINE, ELOCATER, CLAYMORE, SGMINE, C4, SGSATCHEL, SOPDESTAB, PLAYBOY, EMOTIONMAG,
					MANTISDOLL, SORROWDOLL, SHIELD, MASTERKEY, XM320, GP30, SUP_Op, SUP_Mk23, SUP_1911, SUP_M10,
					SUP_P90, SUP_M4, SUP_M14, SCOPE, DOTSIGHT, DSIGHT_MP7, FLIGHT_LG, LASERSIGHT, FLIGHT_HG, FOREGRIPA,
					FOREGRIPB, GATLINGGUN, ATMISSILE, FELASER
				};
				foreach (Weapon_t obj in array)
				{
					obj.InfAmmoFlag = value;
					obj.Magazine = obj.MagSize;
				}
			}
		}

		public Weapon()
		{
			STUNKNIFE = new Weapon_t(5816276u);
			Mk2PISTOL = new Weapon_t(5816328u);
			OPERATOR = new Weapon_t(5816380u);
			Mk23 = new Weapon_t(5816432u);
			PMM = new Weapon_t(5816484u);
			FIVESEVEN = new Weapon_t(5816536u);
			GSR = new Weapon_t(5816588u);
			DE = new Weapon_t(5816640u);
			DE_LB = new Weapon_t(5816692u);
			THOR4570 = new Weapon_t(5816744u);
			_1911CUSTOM = new Weapon_t(5816796u);
			RACEGUN = new Weapon_t(5816848u);
			SOLARGUN = new Weapon_t(5816900u);
			PSS = new Weapon_t(5816952u);
			G18C = new Weapon_t(5817004u);
			TYPE17 = new Weapon_t(5817056u);
			MP7 = new Weapon_t(5817108u);
			MP5SD2 = new Weapon_t(5817160u);
			M10 = new Weapon_t(5817212u);
			P90 = new Weapon_t(5817264u);
			BIZON = new Weapon_t(5817316u);
			PATRIOT = new Weapon_t(5817368u);
			Vz83 = new Weapon_t(5817420u);
			M4CUSTOM = new Weapon_t(5817472u);
			AK102 = new Weapon_t(5817524u);
			G3A3 = new Weapon_t(5817576u);
			AN94 = new Weapon_t(5817628u);
			FALCARBINE = new Weapon_t(5817680u);
			TANEGASHIMA = new Weapon_t(5817732u);
			Mk17 = new Weapon_t(5817784u);
			XM8 = new Weapon_t(5817836u);
			Mk46MOD1 = new Weapon_t(5817888u);
			HK21E = new Weapon_t(5817940u);
			PKM = new Weapon_t(5817992u);
			M60E4 = new Weapon_t(5818044u);
			TWINBARREL = new Weapon_t(5818096u);
			M870CUSTOM = new Weapon_t(5818148u);
			SAIGA12 = new Weapon_t(5818200u);
			VSS = new Weapon_t(5818252u);
			M82A2 = new Weapon_t(5818304u);
			DSR_1 = new Weapon_t(5818356u);
			M14EBR = new Weapon_t(5818408u);
			MOSIN_NAGANT = new Weapon_t(5818460u);
			SVD = new Weapon_t(5818512u);
			RAILGUN = new Weapon_t(5818564u);
			MGL_140 = new Weapon_t(5818616u);
			XM25 = new Weapon_t(5818668u);
			FIM_92A = new Weapon_t(5818720u);
			JAVELIN = new Weapon_t(5818772u);
			RPG_7 = new Weapon_t(5818824u);
			M72A3 = new Weapon_t(5818876u);
			GRENADE = new Weapon_t(5818928u);
			WPG = new Weapon_t(5818980u);
			STUNG = new Weapon_t(5819032u);
			CHAFFG = new Weapon_t(5819084u);
			SMOKEG = new Weapon_t(5819136u);
			SMOKEG_R = new Weapon_t(5819188u);
			SMOKEG_G = new Weapon_t(5819240u);
			SMOKEG_Y = new Weapon_t(5819292u);
			SMOKEG_B = new Weapon_t(5819344u);
			PETROBOMB = new Weapon_t(5819396u);
			MAGAZINE = new Weapon_t(5819448u);
			ELOCATER = new Weapon_t(5819500u);
			CLAYMORE = new Weapon_t(5819552u);
			SGMINE = new Weapon_t(5819604u);
			C4 = new Weapon_t(5819656u);
			SGSATCHEL = new Weapon_t(5819708u);
			SOPDESTAB = new Weapon_t(5819760u);
			PLAYBOY = new Weapon_t(5819812u);
			EMOTIONMAG = new Weapon_t(5819864u);
			MANTISDOLL = new Weapon_t(5819916u);
			SORROWDOLL = new Weapon_t(5819968u);
			SHIELD = new Weapon_t(5820020u);
			MASTERKEY = new Weapon_t(5820072u);
			XM320 = new Weapon_t(5820124u);
			GP30 = new Weapon_t(5820176u);
			SUP_Op = new Weapon_t(5820228u);
			SUP_Mk23 = new Weapon_t(5820280u);
			SUP_1911 = new Weapon_t(5820332u);
			SUP_M10 = new Weapon_t(5820384u);
			SUP_P90 = new Weapon_t(5820436u);
			SUP_M4 = new Weapon_t(5820488u);
			SUP_M14 = new Weapon_t(5820540u);
			SCOPE = new Weapon_t(5820592u);
			DOTSIGHT = new Weapon_t(5820644u);
			DSIGHT_MP7 = new Weapon_t(5820696u);
			FLIGHT_LG = new Weapon_t(5820748u);
			LASERSIGHT = new Weapon_t(5820800u);
			FLIGHT_HG = new Weapon_t(5820852u);
			FOREGRIPA = new Weapon_t(5820904u);
			FOREGRIPB = new Weapon_t(5820956u);
			GATLINGGUN = new Weapon_t(5821008u);
			ATMISSILE = new Weapon_t(5821060u);
			FELASER = new Weapon_t(5821112u);
			NONE = new Weapon_t(5821164u);
			Ammunition = new Ammo();
		}

		public void UnlockWeapons(bool val = true)
		{
			Weapon_t[] array = new Weapon_t[]
			{
				STUNKNIFE, Mk2PISTOL, OPERATOR, Mk23, PMM, FIVESEVEN, GSR, DE, DE_LB, THOR4570,
				_1911CUSTOM, RACEGUN, SOLARGUN, PSS, G18C, TYPE17, MP7, MP5SD2, M10, P90,
				BIZON, PATRIOT, Vz83, M4CUSTOM, AK102, G3A3, AN94, FALCARBINE, TANEGASHIMA, Mk17,
				XM8, Mk46MOD1, HK21E, PKM, M60E4, TWINBARREL, M870CUSTOM, SAIGA12, VSS, M82A2,
				DSR_1, M14EBR, MOSIN_NAGANT, SVD, RAILGUN, MGL_140, XM25, FIM_92A, JAVELIN, RPG_7,
				M72A3, GRENADE, WPG, STUNG, CHAFFG, SMOKEG, SMOKEG_R, SMOKEG_G, SMOKEG_Y, SMOKEG_B,
				PETROBOMB, MAGAZINE, ELOCATER, CLAYMORE, SGMINE, C4, SGSATCHEL, SOPDESTAB, PLAYBOY, EMOTIONMAG,
				MANTISDOLL, SORROWDOLL, SHIELD, MASTERKEY, XM320, GP30, SUP_Op, SUP_Mk23, SUP_1911, SUP_M10,
				SUP_P90, SUP_M4, SUP_M14, SCOPE, DOTSIGHT, DSIGHT_MP7, FLIGHT_LG, LASERSIGHT, FLIGHT_HG, FOREGRIPA,
				FOREGRIPB, GATLINGGUN, ATMISSILE, FELASER, NONE
			};
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Unlocked = val;
			}
		}
	}
}
