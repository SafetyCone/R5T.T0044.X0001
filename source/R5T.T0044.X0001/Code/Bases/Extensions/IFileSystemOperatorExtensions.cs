using System;
using System.Collections.Generic;

using R5T.T0044;

using Instances = R5T.T0044.X0001.Instances;


namespace System
{
    public static class IFileSystemOperatorExtensions
    {
        public static IEnumerable<string> FindProjectFilesInDirectoryOrDirectParentDirectories(this IFileSystemOperator _,
            string directoryPath)
        {
            var output = _.FindFilesInDirectoryOrDirectParentDirectories(
                directoryPath,
                Instances.SearchPattern.AllProjectFiles());

            return output;
        }

        public static IEnumerable<string> FindProjectFilesInFileDirectoryOrDirectParentDirectories(this IFileSystemOperator _,
            string filePath)
        {
            var directoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(filePath);

            var output = _.FindProjectFilesInDirectoryOrDirectParentDirectories(
                directoryPath);

            return output;
        }

        public static IEnumerable<string> FindSolutionFilesInDirectoryOrDirectParentDirectories(this IFileSystemOperator _,
            string directoryPath)
        {
            var output = _.FindFilesInDirectoryOrDirectParentDirectories(
                directoryPath,
                Instances.SearchPattern.AllSolutionFiles());

            return output;
        }

        public static IEnumerable<string> FindSolutionFilesInFileDirectoryOrDirectParentDirectories(this IFileSystemOperator _,
            string filePath)
        {
            var directoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(filePath);

            var output = _.FindSolutionFilesInDirectoryOrDirectParentDirectories(
                directoryPath);

            return output;
        }
    }
}
