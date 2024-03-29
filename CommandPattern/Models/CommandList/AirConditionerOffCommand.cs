﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class AirConditionerOffCommand : ICommand {
    private AirConditioner _airConditioner;
    internal AirConditionerOffCommand(AirConditioner ac) {
      _airConditioner = ac;
    }
    void ICommand.Execute() {
      _airConditioner.Off();
    }
    void ICommand.Undo() {
      _airConditioner.On();
    }
  }
}
