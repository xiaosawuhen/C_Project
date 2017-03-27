using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing;

namespace Controls
{
    public class RichTextBoxScroller : RichTextBox
    {
        private int _iMaxLines = 500;
        private bool _bAutomaticScrollToBottom = true;

        public RichTextBoxScroller()
            : base()
        {
        }

        public void SetMaxLines(int iMaxLines)
        {
            if(iMaxLines <= 0)
            {
                throw new ArgumentOutOfRangeException("iMaxLines", "Must be strictly positive.");
            }
            else
            {
                _iMaxLines = iMaxLines;
            }
        }
		
		public void SetAutomaticScrollToBottom(bool bAutomaticScrollToBottom)
        {
            _bAutomaticScrollToBottom = bAutomaticScrollToBottom;
        }

        public void AppendLine(string strLine)
        {
            AppendLines(new List<string>() { strLine });
        }

        public void AppendLines(IList<string> lstLines)
        {
            if(lstLines.Count == 0)
            {
                return;
            }

            // If you try to add more lines than the max allowed, drop some lines in the beginning of the list.
            var lstNewLines = lstLines;
            if(lstLines.Count > _iMaxLines)
            {
                lstNewLines = new ArraySegment<string>(lstLines.ToArray(), lstLines.Count - _iMaxLines, _iMaxLines);
            }

            Debug.Assert(lstNewLines.Count <= _iMaxLines);

            int iFirstVisibleLineIndex_Begin = GetFirstVisibleLineIndex();

            // Number of lines in the beginning of the text to remove.
            int iLinesToRemove = 0;
            if (Lines.Length + lstNewLines.Count > _iMaxLines)
            {
                iLinesToRemove = Math.Min(Lines.Length, lstNewLines.Count);
            }

            var lstLinesAfterRemovingBeginning = new ArraySegment<string>(Lines, iLinesToRemove, Lines.Length - iLinesToRemove);

            string strNewText;
            if (lstLinesAfterRemovingBeginning.Count == 0)
            {
                strNewText = string.Join(Environment.NewLine, lstNewLines);
            }
            else
            {
                strNewText = string.Join(Environment.NewLine, lstLinesAfterRemovingBeginning) + Environment.NewLine + string.Join(Environment.NewLine, lstNewLines);
            }

            Text = strNewText;

            if(_bAutomaticScrollToBottom)
            {
                SelectionStart = TextLength;
                ScrollToCaret();
            }
            else
            {
                int iFirstVisibleLineIndex_AfterRemoval = Math.Max(0, iFirstVisibleLineIndex_Begin - iLinesToRemove);
                Debug.Assert(iFirstVisibleLineIndex_AfterRemoval >= 0);
                ScrollToLine(iFirstVisibleLineIndex_AfterRemoval);
            }

            // Invariant.
            Debug.Assert(Lines.Length <= _iMaxLines);
        }

        private int GetFirstVisibleLineIndex()
        {
            int iFirstVisibleCharacterIndex = GetCharIndexFromPosition(new Point(1, 1));
            return GetLineFromCharIndex(iFirstVisibleCharacterIndex);
        }

        private void ScrollToLine(int iLineIndex)
        {
            int iCharacterIndex = GetFirstCharIndexFromLine(iLineIndex);
            SelectionStart = iCharacterIndex;
            ScrollToCaret();
        }
    }
}
