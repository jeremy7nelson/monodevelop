﻿using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;

namespace MonoDevelop.Debugger
{
	internal class BreakpointForegroundTagger : AbstractBreakpointTagger<ClassificationTag>
	{
		public BreakpointForegroundTagger (
			ClassificationTag tag,
			ClassificationTag disabled,
			ClassificationTag invalid,
			ITextView textView)
			: base (tag, disabled, invalid, textView)
		{
		}
	}
}
