using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteraction : MonoBehaviour
{
	[SerializeField]
	private List<InteractionSO> _listInteractions = default;

	[SerializeField]
	private UIInteractionIndicator _interactionItem = default;

	public void FillInteractionPanel(InteractionType interactionType)
	{
		if ((_listInteractions != null) && (_interactionItem != null))
			if (_listInteractions.Exists(o => o.InteractionType == interactionType))

			{
				_interactionItem.FillInteractionPanel(_listInteractions.Find(o => o.InteractionType == interactionType));

			}
	}

}
