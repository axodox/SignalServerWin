#include "RadioCoverageSimulation.h"
#include "RadioCoverageSimulation.g.cpp"

namespace winrt::SignalServer::Core::implementation
{
  void RadioCoverageSimulation::TestMethod(double numericArgument)
  {
    printf("Running native code... %f\n", numericArgument);
  }
}
