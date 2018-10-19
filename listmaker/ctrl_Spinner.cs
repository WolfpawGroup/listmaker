using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listmaker
{
	public partial class ctrl_Spinner : UserControl
	{
		private int _chr			= (int)'0'; 
		public int	CurrentCharI	{ get { return _chr; }			set { _chr = value; setchar(); } }
		public char CurrentCharC	{ get { return (char)_chr; }	set { _chr = value; setchar(); } }

		private int _minCharNUM		= (int)'0';	//48
		private int _maxCharNUM		= (int)'9';	//57
		private int _minCharALPHA	= (int)'A';	//65
		private int _maxCharALPHA	= (int)'Z';	//90

		public int MinCharNUM		=> _minCharNUM;
		public int MaxCharNUM		=> _maxCharNUM;
		public int MinCharALPHA		=> _minCharALPHA;
		public int MaxCharALPHA		=> _maxCharALPHA;

		private mode _mode = mode.NUMERIC;
		public mode Mode { get { return _mode; } set { _mode = value; setmode(); } }

		public ctrl_Spinner()
		{
			InitializeComponent();

			tb_Text.MouseWheel += Tb_Text_MouseWheel;
			Load += Ctrl_Spinner_Load;
		}

		private void Tb_Text_MouseWheel(object sender, MouseEventArgs e)
		{
			if(e.Delta > 0) { incrementChar(); }
			else			{ decrementChar(); }
		}

		public void setmode()
		{
			if(_mode != mode.ALPHA) { CurrentCharC = '0'; }
			else { CurrentCharC = 'A'; }
		}

		private void Ctrl_Spinner_Load(object sender, EventArgs e)
		{
			Console.WriteLine(_chr + "");
		}

		public void incrementChar()
		{
			if(_chr == MaxCharALPHA || _chr == MaxCharNUM)
			{
				if (_mode != mode.NUMERIC)
				{
					CurrentCharI = MinCharALPHA;
				}
				else if (_mode != mode.ALPHA)
				{
					CurrentCharI = MinCharNUM;
				}
			}
			else
			{
				CurrentCharI++;
			}
			
		}

		public void decrementChar()
		{
			if (_chr == MinCharALPHA || _chr == MinCharNUM)
			{
				if (_mode != mode.NUMERIC)
				{
					CurrentCharI = MaxCharALPHA;
				}
				else if (_mode != mode.ALPHA)
				{
					CurrentCharI = MaxCharNUM;
				}
			}
			else
			{
				CurrentCharI--;
			}
		}

		public void setchar()
		{
			tb_Text.Text = CurrentCharC.ToString();
		}

		private void btn_Up_Click(object sender, EventArgs e)
		{
			incrementChar();
		}

		private void btn_Down_Click(object sender, EventArgs e)
		{
			decrementChar();
		}

		public string getString()
		{
			return tb_Text.Text;
		}

		public char getChar()
		{
			return CurrentCharC;
		}

		private void tb_Text_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void tb_Text_MouseLeave(object sender, EventArgs e)
		{
			
		}
	}

	public enum mode
	{
		ALPHA,
		NUMERIC,
		ALPHANUMERIC
	}

	public class spinnerArray
	{
		private int _pointer = 0;
		private List<ctrl_Spinner> _spinners = new List<ctrl_Spinner>();

		public List<ctrl_Spinner> ToList()
		{
			return _spinners;
		}

		public ctrl_Spinner[] ToArray()
		{
			return _spinners.ToArray();
		}

		public void Add(ctrl_Spinner spinner)
		{
			_spinners.Add(spinner);
		}

		public void AddRange(List<ctrl_Spinner> spinners)
		{
			foreach (var spinner in spinners)
			{
				_spinners.Add(spinner);
			}
		}

		public void AddRange(ctrl_Spinner[] spinners)
		{
			foreach (var spinner in spinners)
			{
				_spinners.Add(spinner);
			}
		}

		public string getValue()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var spinner in _spinners) { sb.Append(spinner.getString()); }

			return sb.ToString();
		}

		public char getChar(int index)
		{
			if (_spinners.Count <= index)
			{
				return '0';
			}
			else
			{
				return _spinners[index].getChar();
			}
		}

		public char[] getChars()
		{
			char[] sb = new char[_spinners.Count];

			for (int i = 0; i < sb.Length; i++)
			{
				sb[i] = _spinners[i].getChar();
			}

			return sb;
		}

		public byte getByte(int index)
		{
			if (_spinners.Count <= index)
			{
				return 0;
			}
			else
			{
				return (byte)_spinners[index].getChar();
			}
		}

		public byte[] getBytes()
		{
			byte[] sb = new byte[_spinners.Count];

			for (int i = 0; i < sb.Length; i++)
			{
				sb[i] = (byte)_spinners[i].getChar();
			}

			return sb;
		}

		public int pointerPosition()
		{
			return _pointer;
		}

		public void resetPointer()
		{
			_pointer = 0;
		}

		public void setPointer(int index)
		{
			if(index >= _spinners.Count)
			_pointer = index;
		}
	}
}
