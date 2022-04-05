#pragma once
#include "RadioCoverageSimulation.g.h"

namespace winrt::SignalServer::Core::implementation
{
  struct RadioCoverageSimulation : RadioCoverageSimulationT<RadioCoverageSimulation>
  {
    RadioCoverageSimulation() = default;

    void TestMethod(double numericArgument);
  };
}

namespace winrt::SignalServer::Core::factory_implementation
{
  struct RadioCoverageSimulation : RadioCoverageSimulationT<RadioCoverageSimulation, implementation::RadioCoverageSimulation>
  {
  };
}
