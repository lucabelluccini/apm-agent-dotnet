// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Apm.Tests.Utilities.Docker;
using Xunit;

namespace Elastic.Apm.Tests.Utilities.XUnit;

public sealed class DisabledOnWindowsFact : FactAttribute
{
	public DisabledOnWindowsFact()
	{
		if (TestEnvironment.IsWindows)
			Skip = "This test is disabled on Windows.";
	}
}

public sealed class DisabledOnFullFrameworkFact : FactAttribute
{
	public DisabledOnFullFrameworkFact()
	{
#if NETFRAMEWORK
		Skip = "This test is disabled on .NET Full Framework";
#endif
	}
}

/// <summary>
/// May be applied to tests which depend on Linux Docker images which will not be
/// available when running on Windows images from GitHub actions.
/// </summary>
public sealed class DisabledOnWindowsGitHubActionsDockerFact : DockerFactAttribute
{
	public DisabledOnWindowsGitHubActionsDockerFact()
	{
		if (TestEnvironment.IsGitHubActions && TestEnvironment.IsWindows)
			Skip = "This test is disabled on Windows when running under GitHub Actions.";
	}
}

public sealed class DisabledOnWindowsTheory : TheoryAttribute
{
	public DisabledOnWindowsTheory()
	{
		if (TestEnvironment.IsWindows)
			Skip = "This test is disabled on Windows.";
	}
}

public sealed class DisabledOnFullFrameworkTheory : TheoryAttribute
{
	public DisabledOnFullFrameworkTheory()
	{
#if NETFRAMEWORK
		Skip = "This test is disabled on .NET Full Framework";
#endif
	}
}
