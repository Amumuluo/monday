using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GTWEditor
{
    interface ITrigger
    {
        bool IsTriggered(GameObject target);
    }
}
